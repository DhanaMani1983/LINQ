<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

var res = 
	from oi in OrderItems
	where oi.Detail == "Send by Professional Courier."
	select new {oi.Product.Description, 
				oi.Price,
				oi.Order.Customer.Name
				};

res.Dump();				