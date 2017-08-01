# VS2017 Value Tuple Crash

## Steps to reproduce
* Using a class library which targets multiple frameworks (e.g. netstandard1.4, net45), doesn't really matter which ones
* Use the class library in another project (e.g. a console app) which also multi targets (e.g. netcoreapp1.1;net462), again, doesn't matter which targets.
* The class library has a class with a puplic method which returns an IEnumerable of a tupple
* The consumer tries to type `.TupleMethod().Select(`
* The moment Intellisense tries to display information when typing the opening braces, VS crashes

## Screenshot
![crash.png](https://github.com/MichaCo/VS2017ValueTupleBug/raw/master/crash.PNG)
