from abc import abstractmethod
from random import randint
import time
import datetime
import threading
import asyncio

start = time.time()





class Fighter():    # Абстрактный класс-родитель для классов описывающих бойцов

    def __init__(self, name, age, country, weight):
        self.name = name
        self.age = age
        self.country = country
        self.weight = weight
        self.health = 100

    @abstractmethod
    def what_hit(self, a):  #абстрактный метод, который быдет переопределён в дочерних классах - будет определять, какой тип атаки применит боец
        print()

    @abstractmethod
    def inf0(self): #абстрактный метод, который быдет переопределён в дочерних классах - будет выводить информацию о бойце
        print()
class Mixin_Hit_And_Win():# класс-миксин, который отвечает за получение урона и определение победителя
    def get_hit(self):  #метод получения урона
        self.health -= 10
        print(self.health," hp у",  self.name)
    def get_win(self):  #метод, вызываемый при победе
        print(self.name + " WON!!!")


class Boxer(Fighter, Mixin_Hit_And_Win):   #дочерний класс Боксёр
    def __init__(self, name, age, country, weight, title):
        super().__init__(name, age, country, weight)    #переопределён конструктор родительского класса
        self.title = title

    def what_hit(self, a):
        if a == 0:
            print(self.name + ": прописывает двоечку")
        else:
            print(self.name + ": громовым апперкотом отправляет соперника отдуохнуть на мате")
    def inf0(self):
        print("Боксёр(ша) |Прозвище: {0} |Возраст: {1} |Страна: {2} |Вес: {3} |Титул: {4} |".format(self.name, self.age, self.country, self.weight, self.title))

class Karateka(Fighter,Mixin_Hit_And_Win):
    def __init__(self, name, age, country, weight, color):
        super().__init__(name, age, country, weight)
        self.color = color

    def what_hit(self, a):
        if a == 0:
            print(self.name + ": бьёт лоукик")
        else:
            print(self.name + ": молниеносной вертушкой сносит соперника с ног")
    def inf0(self):
        print("Каратист(ка) |Прозвище: {0} |Возраст: {1} |Страна: {2} |Вес: {3} |Пояс: {4} |".format(self.name, self.age, self.country, self.weight, self.color))


class MetaFight(type):#мЕТА- КЛАСС
    # Метод hello
    def sfight(cls):
        print("БОООЙ!!! НАЧИНАЕТСЯ!!!")
    def __call__(self, *args, **kwargs):
       cls = type.__call__(self, *args)
       setattr(cls, "sfight", self.sfight)
       return cls

class MyEx(Exception): #Было создано новое исключение, которое принимает значение в зависимости от конструктора------------------------------------------------------------------------------------------------
    def __init__(self, ee):
        self.__ee=ee
class Fight(metaclass=MetaFight):  #класс, отвечающий за описание самого поединка
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

    def fighting(self, b1, b2): # метод класса, который описывает сам бой, выводя информацию о каждом, нанесённом ударе
        r = 0
        while (b1.health and b2.health) > 0:
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

class Menu():   #класс, который описывает функционал, доступный рядовому пользователю
    def a_decorator_pass_arg(func):# декоратор, который устанавливает значение функции------------------
        def a_wrapper_accepting_arguments(arg1, arg2):
            print("Что ж, выбор сделан...")
            func(arg1, arg2)
        return a_wrapper_accepting_arguments

    def stime(func):# декоратор, выводящий время на запуск поединка и его выполнение-----------------
        def wrapper(self):
            start_time = time.time()
            func(self)
            print("На организацию данного поединка ушло", (round(time.time() - start_time, 4)), " секунд")
        return wrapper

    #@stime
    def what_prefer(self):  #метод, предоставляющий выбор поединка пользователю
        i= input("Добрый день, дамы и господа!\n Рады вам предстваить 3 поединка между каратистами и боксерами на выбор(введите понравившуюся цифру):\n"
                 "1. Пошлый Уил Vs Вездесущий Си\n2. Геракл Vs Киоши\n3. БЫчий Дюк Vs Вертлявая Задира\n5.Завершение программы-демонстрация трех боёв одновременно\n7.3 боя -одновременно\n")
        if(i=="5"):
                raise WPE()#------------------------------------------------------------------------------------С помощью вызова исключения ВПЕ - определяется выход из программы


        return i

    @a_decorator_pass_arg# декоратор
    def choose(self, a): # метод, отвечающий за проведение боя
        i=int(a)
        if i == 1:
            f1 = Boxer("Пошлый Уил", "43", "Омерика", "157кг", "Чемпион штата")
            f2 = Karateka("Вездесущий Си", "39", "Тайвань", "89кг", "Блэк")
            f1.inf0()
            f2.inf0()
            c = Fight()
            c.fighting(f1, f2)
        elif i == 2:
            f1 = Boxer("Геракл", "15", "Греция", "65кг", "Чемпион школы")
            f2 = Karateka("Киоши", "13", "Япония", "49кг", "Белоснежный")
            f1.inf0()
            f2.inf0()
            c = Fight()
            c.fighting(f1, f2)
        elif i==3:
            f1 = Boxer("Бычий Дюк", "23", "Хорватия", "111кг", "Чемпион мира")
            f2 = Karateka("Вертлявая Задира", "Всегда 15", "Россия", "Спрашивать у дамы не прилично", "Подходит под сумочку")
            f1.inf0()
            f2.inf0()
            c=Fight()
            c.fighting(f1, f2)
        elif i ==7:
            th1=ThreadCl("Пошлый Уил", "43", "Омерика", "157кг", "Чемпион штата","Вездесущий Си", "39", "Тайвань", "89кг", "Блэк")
            th2=ThreadCl("Геракл", "15", "Греция", "65кг", "Чемпион школы","Киоши", "13", "Япония", "49кг", "Белоснежный")
            th3=ThreadCl("Бычий Дюк", "23", "Хорватия", "111кг", "Чемпион мира","Вертлявая Задира", "Всегда 15", "Россия", "Спрашивать у дамы не прилично", "Подходит под сумочку")
            th1.start()#Было создано 3 потока, которые позволяю наблюдать за 3 мя боями параллельно------------------------------------------------------------
            time.sleep(0.1)
            th2.start()
            time.sleep(0.1)
            th3.start()

            th1.join()
            th2.join()
            th3.join()


async def cr1():
        f1 = Boxer("Бычий Дюк", "23", "Хорватия", "111кг", "Чемпион мира")
        f2 = Karateka("Вертлявая Задира", "Всегда 15", "Россия", "Спрашивать у дамы не прилично", "Подходит под сумочку")
        await asyncio.sleep(0)
        f1.inf0()
        f2.inf0()
        await asyncio.sleep(0)
        c = Fight()
        c.fighting(f1, f2)
        await asyncio.sleep(0)
async def cr2():
        f1 = Boxer("Геракл", "15", "Греция", "65кг", "Чемпион школы")
        f2 = Karateka("Киоши", "13", "Япония", "49кг", "Белоснежный")
        await asyncio.sleep(0)
        f1.inf0()
        f2.inf0()
        await asyncio.sleep(0)
        c = Fight()
        c.fighting(f1, f2)
        await asyncio.sleep(0)
async def cr3():
        f1 = Boxer("Бычий Дюк", "23", "Хорватия", "111кг", "Чемпион мира")
        f2 = Karateka("Вертлявая Задира", "Всегда 15", "Россия", "Спрашивать у дамы не прилично", "Подходит под сумочку")
        await asyncio.sleep(0)
        f1.inf0()
        f2.inf0()
        await asyncio.sleep(0)
        c = Fight()
        c.fighting(f1, f2)
        await asyncio.sleep(0)
ipp = asyncio.get_event_loop()#-была добавлена возможность асинхронного воспроизведения боя- завершающее выступление-----------------------------
tasks = [
        ipp.create_task(cr1()),
        ipp.create_task(cr2()),
        ipp.create_task(cr3())
    ]

class ThreadCl(threading.Thread):
    def __init__(self,name,age,coun,wei,tit,name1,age1,coun1,wei1,tit1):
        threading.Thread.__init__(self)
        self.f1=Boxer(name,age,coun,wei,tit)
        self.f2=Karateka(name1,age1,coun1,wei1,tit1)
    def run(self):
        self.f1.inf0()
        self.f2.inf0()
        c=Fight()
        c.fighting(self.f1,self.f2)
class TCl(threading.Thread):
    def __init__(self):
        self.date = datetime.date.today()
        threading.Thread.__init__(self)
    def run(self):
        print(datetime.date.today())
def main():
    game = Menu()

    i=1
    while (i==1):
        try:
            aaa=game.what_prefer()
        except WPE:#------------------------------------------------------------------------------------С помощью вызова исключения ВПЕ - определяется выход из программы
            print("the End")
            break
        else:
            game.choose(aaa)
    ipp.run_until_complete(asyncio.wait(tasks))
    ipp.close()


main()
