<h1>Ответы на вопросы</h1>
<h2>№1</h2>
<p>У меня нет опыта разработки веб приложений, если не считать ТГ Бота, находящегося в соответствующем репозитории.</p>
<h2>№3</h2>
<p>CREATE TABLE Products(ProductID int PRIMARY KEY, Name text);</p>
<p>CREATE TABLE Categories(CategoryID int PRIMARY KEY, Name text);</p>
<p>CREATE TABLE ProductCategories(ProductID int, CategoryID int, CONSTRAINT FK_ProductID FOREIGHN KEY(ProductID) REFERENCES Products(ProductID), CONSTRAINT FK_CategoryID FOREIGHN KEY(CategoryID) REFERENCES Categories(CategoryID)); #Нужна для создания отношения много ко многим</p>
<p>SELECT p.Name, c.CategoryName FROM Products as p<br>LEFT JOIN ProductCategories as pc ON p.ProductID = pc.ProductID<br>LEFT JOIN Categories as c ON c.CategoryID = pc. CategoryID;</p>
<h2>№4</h2>
<p>Да, я готов выйти на удаленную работу после стажировки</p>
