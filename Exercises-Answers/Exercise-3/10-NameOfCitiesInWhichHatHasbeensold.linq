<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Name of the cities in which Hat has been sold.

var res =
	from oi in OrderItems
	where oi.Product.Description == "hat"
	select oi.Order.Customer.City.CityName;
	
res.Distinct().Dump();	