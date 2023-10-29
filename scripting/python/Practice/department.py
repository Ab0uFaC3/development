from employee import Employee

class Department(Employee):

	def __init__(self, dept_id, dept_name, emp_name):
		self.department_id = dept_id
		self.department_name = dept_name
		self.employee_name = emp_name

e1 = Employee()
d1 = Department(2, "IT", e1.employee_name)
print(d1.department_id)

print(d1.department_name)

print(d1.employee_name)

# Way to access private variable in another class
# object-of-class._class-name__private-variable-name
print(e1._Employee__employee_id)
