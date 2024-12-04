using Antlr4.Runtime;
using Lenguaje;
using Lenguaje.Content;

var filename = "Content\\test.ss"; //args[0] ?
var fileContents = File.ReadAllText(filename);

var inputStream = new AntlrInputStream(fileContents);

var simpleLexer = new SimpleLexer(inputStream);
CommonTokenStream commonTokenStream = new CommonTokenStream(simpleLexer);
var simpleParser = new SimpleParser(commonTokenStream);
var simpleContext = simpleParser.program();
var visitor = new SimpleVisitor();
visitor.Visit(simpleContext);
