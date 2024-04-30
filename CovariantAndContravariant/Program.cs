// See https://aka.ms/new-console-template for more information

using CovariantAndContravariant;
using System.Net.Http.Headers;

var test = new Test();
var apple = new X<Apple>();
var orange = new X<Orange>();

test.GetIxFruit(apple);
test.GetIxFruit(orange);


// Covariant : out 
// Parent <- Child 
IEnumerable<string> strings = new List<string>();
IEnumerable<object> objects = strings;

//Contravariant : in 
//Child <- Parent

void SetObject(object obj) { }
Action<object> objAction = SetObject;
Action<string> stringAction = objAction;

