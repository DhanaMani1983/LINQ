<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// States in which Camera not sold.

var res =
	States.Except(
		(from oi in OrderItems
		where oi.Product.Description == "Camera"
		select oi.Order.Customer.City.State).Distinct()
	);
	
res.Dump();	