/*
Create function conc which should concatenate two parameters a and b and return concatanating string using Function Declaration Statement (FDS). 
Call this function before its declaration. 
Test Data: 
a = “1”, b = “1”, result = “11” 
a = 1, b = 1, result = “11”
*/

conc (1,1)
//conc ('1','1')

function conc (a,b) {
	return (a).toString() + (b).toString()
};

/*
Create function comp which should compare two parameters a and b and return 1 if a equal b and -1 if a not equal b using Function Definition 
Expression (FDE). Call this function before its declaration. 
Test Data: 
a = “abc”, b = “abc”, result = 1 
a = “abC”, b = “abc”, result = -1
*/

var validate = function comp(a,b) {
	if(a == b) {
		return 1
	}
	else {
		return -1
	}
};

//validate('abc','abc')
validate('abC','abc')

/*
Create anonymous function which should log message “message in console” to the console and use it as a click handler for button // what?
*/

var anon = function(){
	console.log ('message in console')
};

anon();

/*
Create function fibo to calculate fibonachi numbers using named function expression
*/

var fiboRun = function fibo(x) {

	if (x < 1)
		return 0;

	if (x <= 2)
		return 1;

   return fibo(x - 1) + fibo(x - 2);
};

fiboRun(5);

/*
Make the function concimmediately-invoked function expression
*/

(function() {
	console.log("immediate as hell")
})();

/*
Create 4 classes.
Class A
1. property p1 = 2 (default value). Property can be overridden in the constructor by passing argument p.
2. method f1() returns 7
Class B extends class A
1. property p2 = ‘Hello’ (default value)
2. method f2(x) returns 2 * x
Class C extends class B
1. overrides the property p2 = ‘Bye’
Class D – extends class C
1. property p4 = 7 * p1
2. Overrides method f2(x), which should return the value of method f2() from parent class * 5.
3. method f4(x) – returns sum of f1() and f2()
Create instances of these classes and output them to console.
Calculate the value of method f4(1).
*/

class A {
	constructor(p) {
		this.p1 = p;
	}
	
	f1() {
		return 7;
	}
};

class B extends A {
	constructor(p1, p2) {
		super(p1);
		this.p2 = 'Hello';
	}
	
	f2(x) {
		return 2 * x
	}
};

class C extends B {
	constructor(p1,p2) {
		super(p1)
		this.p2 = 'Bye'
	}
};

class D extends C {
	constructor(p1,p2,p4) {
		super(p1,p2)
		this.p4 = 7 * p1
	}
	
	f2(x) {
		return super.f2(x) * 5
	}
	
	f4(x) {
		super.f1() + super.f2()
	}		
};

let a = new A();
let b = new B();
let c = new C();
let d = new D();

console.log(a,b,c,d);

