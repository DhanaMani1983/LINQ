<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Cities in which Car has not been sold out.

var res =
	Cities.Except(
		(from oi in OrderItems
		where oi.Product.Description == "Car"
		select oi.Order.Customer.City).Distinct()
	);
	
res.Dump();	