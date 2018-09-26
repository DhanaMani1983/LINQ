<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Distinct years of Car Sold.
var res = 
	from oi in OrderItems
	join o in Orders on oi.OrderId equals o.ID
	where oi.Product.Description == "car"
	select o.Date.Year;

res.Distinct().Dump();