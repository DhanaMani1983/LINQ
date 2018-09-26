<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Latest Car Sales Date.

var res =
	from oi in OrderItems
	where oi.Product.Description == "Car"
	orderby oi.Order.Date descending
	select oi.Order.Date;
	
res.First().Dump();	