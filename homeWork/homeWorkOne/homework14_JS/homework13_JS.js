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

