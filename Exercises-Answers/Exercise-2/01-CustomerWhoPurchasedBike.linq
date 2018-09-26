<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customers who purchased Bike
var res = 
	from oi in OrderItems
	// join o in Orders on oi.OrderId equals o.ID
	// join c in Customers on o.CustomerID equals c.ID
	where oi.Product.Description == "Bike"
	orderby oi.Order.BillNo
	select new {oi.Order.Date, oi.Order.BillNo, oi.Order.Customer.Name, oi.Price};

res.Distinct().Dump();