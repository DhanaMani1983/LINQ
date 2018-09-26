<Query Kind="Statements">
  <Connection>
    <ID>5bb60b27-ad81-403e-b12b-d71826d34ace</ID>
    <Persist>true</Persist>
    <Server>192.168.1.1</Server>
    <SqlSecurity>true</SqlSecurity>
    <Database>LinqPractice</Database>
    <UserName>training</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAWmX7/Q/gZECft6tWy96CHwAAAAACAAAAAAAQZgAAAAEAACAAAAApMIaJ3HHeEXy2Gm1bV+Uy40dBOqMVMgtncTA32TB04QAAAAAOgAAAAAIAACAAAADX2397SXZiuns5FST2BFsxsOvu0gYObS5aXpQ9G50ZXhAAAABVVJsQpWfPrrg0pgGtCJZJQAAAABqBRYEEJ7kQaoGRuZJdsD1O2gXSOcK4mEpZwtD5lcKhoqy98+9BLltdNTGE3r1pDLkKooLPKS0LU6jnefB1e1Y=</Password>
  </Connection>
</Query>

// Citywise, Statewise Sales analysis.
var res = 
	from o in Orders
	where o.Customer != null
	group o by new {o.Customer.City.CityName,
					o.Customer.City.State.StateName,
				} into sales
	select new {sales.Key.CityName, 
				sales.Key.StateName,
				NoOfSales=sales.Count(),
				TotalSales=sales.Sum (s => s.TotalSalesAmount)};

res.Dump();