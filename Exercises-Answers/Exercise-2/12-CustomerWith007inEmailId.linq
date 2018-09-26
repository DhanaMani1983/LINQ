<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customer with 007 as part of their email.

var c007 = Customers.Where (c => c.EmailId.Contains("007"));

// Find the Order Items.
var oitems =
	from o in Orders
	where o.CustomerID == c007.First().ID
	from oi in o.OrderItems
	select new {o.Customer.Name, o.BillNo, o.Date, oi.Product.Description, oi.Price};
	
oitems.Dump();