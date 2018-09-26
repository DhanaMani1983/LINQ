<Query Kind="Statements">
  <Connection>
    <ID>dc6546dd-0ed0-4a47-89d8-c787dc4e85d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

int[] numbers = { 10, 12, 8, 24, 6 };

numbers.Any (n => n%2==1).Dump();