class Employee:
	def __init__(self):
		self.__employee_id = 1
		self.employee_name = "xyz"

	
		
	def printname(self):
    		return self.__employee_id

e1 = Employee()
print(e1.printname())

