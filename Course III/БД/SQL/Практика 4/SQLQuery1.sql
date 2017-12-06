Select usr.UserID, usr.Name  UserName, Blog.Name  BlogName, RegistrationDate,CreateDate
 From BlogUser  usr
JOIN Blog ON usr.UserID= Blog.BlogId
