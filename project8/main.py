from abc import abstractmethod
from random import randint
import time
import datetime
import threading
import asyncio
#from tkinter import *
import tkinter as tk
start = time.time()

class Application(tk.Frame):#Был создан интерфейс выбора противников
    def __init__(self, master=None):
        super().__init__(master)
        self.master = master
        self.pack()
        self.create()
    def create(self):
        self.master.title("Введите цифру:")
        self.text = tk.Text(self)
        self.text.insert(tk.INSERT,
                    "Добрый день, дамы и господа!\n Рады вам предстваить 3 поединка между каратистами и боксерами на выбор(введите понравившуюся цифру):\n"
                    "1. Пошлый Уил Vs Вездесущий Си\n2. Геракл Vs Киоши\n3. БЫчий Дюк Vs Вертлявая Задира\n7.3 боя -одновременно\n")
        self.e = tk.Entry(self, width=30)
        self.b = tk.Button(self, text="start")
        self.l = tk.Label(self, bg="black")
        self.b.bind('<Button-1>', self.returnint)
        self.text.pack()
        self.e.pack()
        self.b.pack()
        self.l.pack()
    def returnint(self, e):
        game = Menu()

        game.choose(self.e.get())
#----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
class CreateFi:#Бфла создана абстрактная фабрика, позволяющая создавать бойцов различных типов
    def __init__(self, name, age, country, weight, title,type=None, strategy=None ):#была добавлена стратегия
        self.type= type
        self.name= name
        self.age = age
        self.country = country
        self.weight=weight
        self.title=title
        self.health=100
        self.strategy = strategy
    def inf0(self):
        b = self.type()
        print("{0} |Прозвище: {1} |Возраст: {2} |Страна: {3} |Вес: {4} |Титул: {5} |".format(b, self.name, self.age, self.country, self.weight, self.title))
    def what_hit(self, a):
        b = self.type()
        if a==0:
            print(self.name+b.fig(a, self.strategy))
        else:
            print(self.name+ b.fig(a, self.strategy))
    def get_hit(self):  #метод получения урона
        if self.strategy:
            self.health-=self.strategy(self)
        else:
            self.health -= 10
        if self.health <=0:
            self.health=0
        print(self.health," hp у",  self.name)
    def get_win(self):  #метод, вызываемый при победе
        print(self.name + " WON!!!")
def knife_w(self):
    return 30;
def blade_w(self):
    return 20;
class Boxer1:
    def __str__(self):
        return "Боксёр(ша)"
    def fig(self,a, strategy):
        if a==0:
            if strategy==knife_w:
                return ": вскользь полоснул"
            elif strategy==blade_w:
                return ": рубанул отдуши"
            else:
                return ": прописывает двоечку"
        else:
            return ": громовым апперкотом отправляет соперника отдуохнуть на мате"
class Karateka1:
    def __str__(self):
        return "Каратист(ка)"

    def fig(self, a,strategy):
        if a == 0:
            if strategy==knife_w:
                return ": во время сальто полоснул"
            elif strategy==blade_w:
                return ": совершил удар в прыжке"
            else:
                return ": бьёт лоукик"
        else:
            return ": молниеносной вертушкой сносит соперника с ног"
#------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




class MyEx(Exception): #Было создано новое исключение, которое принимает значение в зависимости от конструктора------------------------------------------------------------------------------------------------
    def __init__(self, ee):
        self.__ee=ee
class Fight():  #класс, отвечающий за описание самого поединка
    def greet(self):
        self.sfight()

    def who_will_hit(self, f1, f2): #случайно определяет того, кто нанесёт урон и какой тип атаки совершит
        if randint(0, 1) == 0:
            if f1.health > 10:
                i = 0
            else:
                i = 1
            f2.what_hit(i)
            f1.get_hit()

        else:
            if f2.health > 10:
                i = 0
            else:
                i = 1
            f1.what_hit(i)
            f2.get_hit()
    def stime(func):  # декоратор, выводящий время выполнения поединка-----------------
        def wrapper(self, b1,b2):
            start_time = time.time()
            func(self, b1, b2)
            print("Бой длился", (round(time.time() - start_time, 4)), " секунд")
        return wrapper
    @stime
    def fighting(self, b1, b2): # метод класса, который описывает сам бой, выводя информацию о каждом, нанесённом ударе
        r = 0
        while (b1.health and b2.health) > 0:
            time.sleep(0.05)
            r += 1
            print(r, " удар")
            self.who_will_hit(b1, b2)
            print("_____________________________________________________________________________")
            try:
                if b1.health <= 0: # условие при котором определяется победитель
                    #b2.get_win()
                    raise MyEx("К сожалению, во время поединка произошла ошибка и боец1 проиграл(((")#было запущенно исклбчение------------------------------------------------------------------------------------------------
                elif (b1.health==0 and b2.health ==0):
                    print("Победила дружба!!!")
                elif b2.health<=0:
                    b1.get_win()
            except MyEx as aa:
                print(aa)






class WPE(Exception): pass

class Menu(object):   #класс, который описывает функционал, доступный рядовому пользователю
    def __new__(cls):
        if not hasattr(cls, 'instance'):
            cls.instance = super(Menu, cls).__new__(cls)
        return cls.instance
    def what_prefer(self):  #метод, предоставляющий выбор поединка пользователю
        i= input("Добрый день, дамы и господа!\n Рады вам предстваить 3 поединка между каратистами и боксерами на выбор(введите понравившуюся цифру):\n"
                 "1. Пошлый Уил Vs Вездесущий Си\n2. Геракл Vs Киоши\n3. БЫчий Дюк Vs Вертлявая Задира\n4.Бездомный бродяга Vs НАчинающий ниндзя на мечах\n5.Завершение программы\n")
        if(i=="5"):
                raise WPE()#------------------------------------------------------------------------------------С помощью вызова исключения ВПЕ - определяется выход из программы
        return i
    def choose(self, a): # метод, отвечающий за проведение боя
        i=int(a)
        if i == 1:
            f1 = CreateFi("Пошлый Уил", "43", "Омерика", "157кг", "Чемпион штата", Boxer1)
            f2 = CreateFi("Вездесущий Си", "39", "Тайвань", "89кг", "Блэк", Karateka1)
            f1.inf0()
            f2.inf0()
            c = Fight()
            c.fighting(f1, f2)
        elif i == 2:
            f1 = Boxer("Геракл", "15", "Греция", "65кг", "Чемпион школы", Boxer1)
            f2 = Karateka("Киоши", "13", "Япония", "49кг", "Белоснежный", Karateka1)
            f1.inf0()
            f2.inf0()
            c = Fight()
            c.fighting(f1, f2)
        elif i==3:
            f1 = CreateFi("Бычий Дюк", "23", "Хорватия", "111кг", "Чемпион мира", Boxer1)
            f2 = CreateFi("Вертлявая Задира", "Всегда 15", "Россия", "Спрашивать у дамы не прилично", "Подходит под сумочку", Karateka1)
            f1.inf0()
            f2.inf0()
            c=Fight()
            c.fighting(f1, f2)
        elif i ==4:
            f1 = CreateFi("Бездомный бродяга", "23", "Хорватия", "111кг", "Чемпион мира", Boxer1, strategy=blade_w)
            f2 = CreateFi("НАчинающий ниндзя", "9", "Россия", "Спрашивать у дамы не прилично", "Подходит под сумочку", Karateka1, strategy=knife_w)
            f1.inf0()
            f2.inf0()
            c = Fight()
            c.fighting(f1, f2)


def main():

    game = Menu()
    game1=Menu()
    print("game object:", game)
    print("game1 object:", game1)

    i=1
    while (i==1):
        a = input("Если хотите выбирать бойцов с консоли - нажмите 3:\n")
        if(int(a)==3):
            try:

                aaa=game.what_prefer()
            except WPE:#------------------------------------------------------------------------------------С помощью вызова исключения ВПЕ - определяется выход из программы
                print("the End")
                break
            else:
                game.choose(aaa)

        else:
            root = tk.Tk()
            app = Application(master=root)
            app.mainloop()
main()
