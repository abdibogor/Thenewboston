import java.util.Scanner;

class apples{
    public static void main(String args[]){
        Scanner bucky = new Scanner(System.in);
        double fnum, snum, answer;
        System.out.println("Enter first num: ");
        fnum = bucky.nextDouble();
        System.out.println("Enter second num: ");
        snum = bucky.nextDouble();
        answer = fnum + snum;
        System.out.println(answer);
    }
}

// I think everyone (including me) stepped on a big mistake of inputing a double number such as "34.6" instead of "34,6". Placing a (.) instead of comma (,)