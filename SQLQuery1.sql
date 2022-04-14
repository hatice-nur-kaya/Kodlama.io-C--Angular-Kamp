--Select
Select * from Customers 
Select ContactName , City from Customers
Select ContactName Adi, City Sehir from Customers

Select * from Customers where City ='Londra'

Select * from Products

--case insensitive
select * from Products where CategoryID =1 or CategoryID=3
select * from Products where CategoryID =1 and UnitPrice>=10

--orderby
select *from Products order by ProductName
select *from Products order by ProductName desc --azala
select *from Products order by ProductName asc --artan
--group by
select COUNt (*) from Products --Tüm satırları say ve sayısını ver.
--hangi kategoride kaç farklı ürünümüz var
select CategoryID, count(*) from Products group by CategoryID

--sayısı az olan kategorileri listele
select CategoryID, count(*) from Products group by CategoryID having count(*) <10
select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*) <10

select *from products inner join Categories on Products.CategoryID =Categories.CategoryID
select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID
select * from Products p left join [Order Details] od on p.ProductID = od.ProductID  --solda olup sağda olmayanları da getir
select * from Customers c left join [Orders] o on c.CustomerID = o.CustomerID  --solda olup sağda olmayanları da getir

select * from Customers c left join [Orders] o on c.CustomerID = o.CustomerID  
 where o.CustomerID is null  --üye olup hiç ürün almayan kişiler

select * from Customers c right join [Orders] o on c.CustomerID = o.CustomerID  

Select p.ProductName as urun , sum(od.Quantity * p.UnitPrice) as kazanilanToplamMiktar
from Products as p inner join [Order Details] as od 
on p.ProductID = od.ProductID 
inner join Orders o 
on o.OrderID = od.OrderID
group by p.ProductName order by kazanilanToplamMiktar desc