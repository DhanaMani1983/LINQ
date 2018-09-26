<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customers with more than 6 items in an order.
var res =
	from o in Orders
	where o.OrderItems.Count() > 6
	select o.Customer.Name;
	
res.Distinct().Dump();	