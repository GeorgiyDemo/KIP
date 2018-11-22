class Customer:
  
  def __init__(self, id, name, telephone):
    self.custID = id
    self.custName = name
    self.custTelephone = telephone
  
  def __str__(self):
    return str.format("ID: {0}\tName: {1}\tTelephone: {2}", 
                      self.custID, self.custName, self.custTelephone)


class CustomerDB:
  
  def __init__(self):
    self.customerDatabase = {}
  
  def storeCustomer(self, customer):
   self.customerDatabase[customer.custID] = customer
 
  def getCustomer(self, id):
    return self.customerDatabase[id]
  
  def __str__(self):
    list = "Customers\n"
    for id, cust in self.customerDatabase.iteritems():
      list += str.format("{0}", cust) + "\n"
    return list

def GetNewCustomer(id, name, telephone):
  return Customer(id, name, telephone)

def GetCustomerDB():
  return CustomerDB()

