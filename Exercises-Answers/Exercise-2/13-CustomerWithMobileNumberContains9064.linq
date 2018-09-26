<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customer with mobile number contains 9064
var cname = Customers.Where (c => c.Mobile.Contains("9064")).Select (c => c.Customer).Dump();