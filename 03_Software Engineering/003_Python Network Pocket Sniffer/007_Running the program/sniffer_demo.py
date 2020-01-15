import socket
import struct
import textwrap

TAB_1 = '\t'
TAB_2 = '\t\t'
TAB_3 = '\t\t\t'
TAB_4 = '\t\t\t\t'

DATA_TAB_1 = '\t'
DATA_TAB_2 = '\t\t'
DATA_TAB_3 = '\t\t\t'
DATA_TAB_4 = '\t\t\t\t'

#3_Capturing Traffic
def main():
    conn = socket.socket(socket.AF_PACKET, socket.SOCK_RAW, socket.ntohs(3))

    while True:
        raw_data, addr = conn.recvfrom(65536)
        dest_mac, src_mac, eth_photo, data = ethernet_frame(raw_data)
        print('\nEthernet Frame:')
        print(TAB_1 + 'Destination: {}, Source: {}, Protocol: {}'.format())

     # 8 for IPV4
        if eth_proto == 8:
            (version, header_length, ttl, proto, src, target, data) = ipv4_packet(data)
            print(TAB_1 + 'IPV4 Packet:')
            print(TAB_2 + 'Version: {}, header Length: {}, TTL: {}'.format(version, header_length, ttl))
            print(TAB_2 + 'Protocol: {}, Source: {}, Target: {}, TTL: {}'.format(proto, src, target))

            if proto == 1:
                icmp_type, code, checksum, data = icmp_packet(data)
                print(TAB_1 + 'IPV4 Packet:')
                print(TAB_2 + 'Type: {}, Code: {}, Checksum: {}'.format(icmp_type, code, checksum))
                print(TAB_2 + 'Data:')
                print(fromat_multi_line(DATA_TAB_3, data))

# Unpack ethernet frame
def ethernet_frame(data):
    dest_mac, src_mac, proto = struct.unpack('! 6s 6s H', data[:14])
    return get_mac_addr(dest_mac), get_mac_addr(sr_mac), socket.htons(proto), data[14:]

#2_Formatting MAC Address
# Return properly formatted MAC address (ie AA:BB:CC:DD:EE:FF)
def get_mac_addr(bytes_addr):
    bytes_str = map('{:02x}'.format, bytes_addr)
    return ':'.join(bytes_str).upper()

#4_Unpacking IP Pakcet Headers
def ipv4_packet(data):
    version_header_length = data[0]
    version = version_header_length >> 4
    header_length = (version_header_length & 15) * 4
    ttl, proto, src, target = struct.unpack('! 8* B B 2* 4s 4s', data[:20])
    return version, header_length, ttl, proto, ipv4(src), ipv4(target), data[header_length:]

#127.0.0.1
# Returns properly formatted IPV4 address
def ipv4(addr):
    return '.'.join(map(str, addr))

#5_Unpacking ICMP and TCP Data
def icmp_packet(data):
    icmp_type, code, checksum = struct.unpack('! B B H', data[:4])
    return icmp_type, code, checksum, data[4:]

# Unpacks TCP segment
def tcp_segment(data):
    (src_port, dest_port, sequence_acknowledgement, offset_reserved_flags) = struct.unpack('! H H L L H', data[:14])
    offset = (offset_reserved_flags >> 12) * 4
    flag_url = (offset_reserved_flags & 32) >> 5
    flag_ack = (offset_reserved_flags & 16) >> 4
    flag_psh = (offset_reserved_flags & 8) >> 3
    flag_rst = (offset_reserved_flags & 4) >> 2
    flag_syn = (offset_reserved_flags & 2) >> 1
    flag_fln =  offset_reserved_flags & 1
    return src_port, dest_port, sequence, sequence_acknowledgement, flag_urg, flag_ack, flag_psh, flag_rst, flag_fin, data[offset:]

#6_Displaying Packet Data
# Unpack UDP segment
def udp_segment(data):
    src_port, dest_port, size = struct.unpack('! H H 2* H', data[:8])
    return src_port, dest_port, size, data[8:]

# Formats multi-line data
def format_multi-line(prefix, string, size=80);
size -= len(prefix)
if isinstance(string, bytes):
    string = ''.join(r '\x{:02*}'.format(byte) for byte in string)
    if size % 2:
        size -= 1
        return '\n'.join([prefix +  line for line in textwrap.wrap(string, size)])

main()