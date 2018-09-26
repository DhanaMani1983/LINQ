<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Citywise Productwise Sales Analysis
var res =
	from oi in OrderItems
	where oi.Order.Customer != null &&
		  oi.Product != null
	group oi by new {oi.Order.Customer.City.CityName,
			oi.Product.Description} into sales
	select new {sales.Key.CityName, 
				ProductName=sales.Key.Description,
				TotalSales=sales.Sum (s => s.Price)};
	
res.OrderBy (r => r.CityName).ThenBy(r => r.ProductName).Dump();	