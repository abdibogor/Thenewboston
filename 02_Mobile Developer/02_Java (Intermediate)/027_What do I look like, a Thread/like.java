public class like {
	public static void main(String[] args){
		
		        Thread t1 = new Thread(new Learning("one"));
		        Thread t2 = new Thread(new Learning("two"));
		        Thread t3 = new Thread(new Learning("three"));
		        Thread t4 = new Thread(new Learning("four"));
		        
		        t1.start();
		        t2.start();
		        t3.start(); 
		        t4.start();
		        
		  }
}