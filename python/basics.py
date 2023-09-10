#!/bin/python3

#STRING
print('----------------------String---------------------------')
print("Hello World")

print('\n')
print('----------------------Math---------------------------')
#MATH
print(50 / 6) # quotient with decimals
print(50 % 6) # remainder
print(50 ** 2) # exponential
print(50 // 6) # quotient without decimals

print('\n')
print('----------------------Variables and Methods---------------------------')

quote = 'Happy Learning Python'

print(quote)
print(quote.upper()) # Upper case
print(quote.lower()) # Lower case
print(quote.title()) # Title case

print('\n')
print('----------------------Functions---------------------------')

def print_statement(value):
	print(value)

def drinks(age, money):
	if age >= 21 and money > 5:
		return "You will get a drink"
	elif age >= 21 and money < 5:
		return "Not enough money"
	elif age < 21 and money > 5:
		return "You are a child"
	else:
		return "Not your cup of tea"

print_statement(drinks(22, 7))
print_statement(drinks(25, 3))
print_statement(drinks(20, 6))
print_statement(drinks(18, 3))

print('\n')
print('----------------------Advanced strings---------------------------')

value = 'This is a sentence.'
joined_value = '-'.join(value.split())
print(joined_value)

color = "black"
print("My favourite color is {}.".format(color)) #format method
print("My favourite color is %s." % color) # percent formatting
print(f"My favourite color is {color}.") # string literal

print('\n')
print('----------------------Importing---------------------------')

import sys
from datetime import datetime
print(sys.version)
print(datetime.now())

print('\n')
print('----------------------Sockets---------------------------')

import socket

#change the ip address and port
HOST = ''
PORT = 0

# AF_INET = ipv4, SOCK_STREAM = port
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((HOST, PORT))





















