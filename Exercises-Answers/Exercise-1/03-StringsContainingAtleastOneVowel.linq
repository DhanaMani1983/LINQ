<Query Kind="Statements">
  <Connection>
    <ID>dc6546dd-0ed0-4a47-89d8-c787dc4e85d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

string[] names = { "Try", "Dick", "Harry", "Mary", "Jay" };

IEnumerable<string> query = names
	.Where   (n => Regex.IsMatch(n, "[aeiou]"))
	.OrderBy (n => n.Length)
	.Select  (n => n.ToUpper());
	
query.Dump();
