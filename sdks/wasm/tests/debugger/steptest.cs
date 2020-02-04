using System;

public class HotStepper { //Only append content to this class as the test suite depends on line info
	public static int DoIt () {		
		int c = a + b; 
		int d = c + b;
		int e = d + a;
		int f = 0;
		int x = f;
		return x;
	}

	public static int Now (int x) {
		int test = 10;
		test += x;
		return test;
	}
}