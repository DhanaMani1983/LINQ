<Query Kind="Statements">
  <Connection>
    <ID>dc6546dd-0ed0-4a47-89d8-c787dc4e85d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

float[] numbers = { 1, -6, 10, 10, 9, 4.2F, 8, 8.1F, 72, 60 };

numbers.OrderBy (n => n).Dump("Sorted List").
ElementAt(3).Dump("4th Element");