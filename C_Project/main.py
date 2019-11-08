# ------------------------------------------------------------

# IMPORT!!!!!!!!!!!!!!!!
import math
import tkinter as tk
from tkinter import ttk
from tkinter import messagebox

# ------------------------------------------------------------

# SETUP!!!!!!!!!!!!!!!!
app = tk.Tk() 
app.title("Calculator")
app.iconbitmap('c_project.ico')
app.resizable(0,0)
app.configure(bg='#2c3e50')
# ------------------------------------------------------------

# FUNCTIONS!!!!!!!!!!!!!!!!
def fucMath():
    geta = tbA.get("1.0","end-1c")
    getb = tbB.get("1.0","end-1c")
    op = Operators.current()

    if geta.isdigit() and getb.isdigit():
        a = int(tbA.get("1.0","end-1c"))
        b = int(tbB.get("1.0","end-1c"))
        if op == 0:
            x = a + b
        elif op == 1:
            x = a - b
        elif op == 2:
            x = a * b
        elif op == 3:
            x = a ** b
        elif op == 4:
            x = a / b
        elif op == 5:
            x = a % b
        label["text"] = "=", x

    else:
        messagebox.showinfo("information","ตัวเลขเท่านั้น!!")
        pass
    print("------------------------------------------------------------")
    print("A =",a)
    print("B =",b)
    print("Operators :", Operators.get())
    print("Result :", x)
    pass

# ------------------------------------------------------------

# GUI!!!!!!!!!!!!!!!!
tbA = tk.Text(app,height = 5, width = 10,font=("", 25))
tbA.configure(bg='#34495e',fg='#ecf0f1')
tbA.grid(column=0, row=0,padx = 10, pady = 10)

Operators = ttk.Combobox(app,state="readonly",width=4,font = ("",25),
                            values=[
                                    "+", 
                                    "-",
                                    "×",
                                    "^",
                                    "÷",
                                    "mod",])
Operators.grid(column=1, row=0,padx = 10, pady = 10)
Operators.current(0)

tbB = tk.Text(app,height = 5, width = 10,font=("", 25))
tbB.configure(bg='#34495e',fg='#ecf0f1')
tbB.grid(column=2, row=0,padx = 10, pady = 10)

buttom = tk.Button(app, text = "Result", command = fucMath, width = 10,height = 10,font = ("",10))
buttom.configure(bg='#2c3e50',fg='#ecf0f1')
buttom.grid(column=3, row=0,padx = 10, pady = 10)

label = tk.Label(app, text = "= 0",font=("", 25))
label.configure(bg='#2c3e50',fg='#ecf0f1')
label.grid(column=1, row=1,padx = 10, pady = 10)

cr = tk.Label(app, text = "สร้างโดย \n PSM-Com \n สำหรับงานวิชาการ",font = 10)
cr.configure(bg='#2c3e50',fg='#ecf0f1')
cr.grid(column=3, row=1,padx = 10, pady = 10)

# ------------------------------------------------------------
app.mainloop()

