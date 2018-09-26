<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Fast Moving Items (More than 5)
var res =
	from oi in OrderItems
	where oi.Product != null
	group oi by oi.Product.Description into sales
	select new {ProductName=sales.Key,
				NoOfSales=sales.Count()} into x
	where x.NoOfSales>5
	orderby x.NoOfSales descending 
	select x;
		
res.Dump();