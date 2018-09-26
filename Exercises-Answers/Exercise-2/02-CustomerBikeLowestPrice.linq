<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customers who purchased Bike at lowest price
var res = 
	(from oi in OrderItems
	join o in Orders on oi.OrderId equals o.ID
	join c in Customers on o.CustomerID equals c.ID
	where oi.Product.Description == "Bike"
	orderby oi.Price
	select new {c.Name, oi.Price}
	).First();

res.Dump();