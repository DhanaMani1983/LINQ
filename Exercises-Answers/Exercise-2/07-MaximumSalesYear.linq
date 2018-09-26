<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Year of Maximum Sales Total.
var res = 
	(
	from o in Orders 
	group o by o.Date.Year into items	
	select new {Year=items.Key, TotalSales=items.Sum (i => i.TotalSalesAmount)})
	.OrderByDescending (r => r.TotalSales).First ();

res.Year.Dump();
