<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Name of the States in which Bike has been sold.

var res =
	from oi in OrderItems
	where oi.Product.Description == "Bike"
	select oi.Order.Customer.City.State.StateName;
	
res.Distinct().Dump();	

