from abc import abstractmethod
from random import randint


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



class Fight():  #класс, отвечающий за описание самого поединка
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
        if b1.health <= 0: # условие при котором определяется победитель
            b2.get_win()
        elif (b1.health==0 and b2.health ==0):
            print("Победила дружба")
        else:
            b1.get_win()

class Menu():   #класс, который описывает функционал, доступный рядовому пользователю
    def what_prefer(self):  #метод, предоставляющий выбор поединка пользователю
        i= input("Добрый день, дамы и господа!\n Рады вам предстваить 3 поединка между каратистами и боксерами на выбор(введите понравившуюся цифру):\n"
                 "1. Пошлый Уил Vs Вездесущий Си\n2. Геракл Vs Киоши\n3. БЫчий Дюк Vs Вертлявая Задира\n")
        return i
    def choose(self, i): # метод, отвечающий за проведение боя
        if i == 1:
            f1 = Boxer("Пошлый Уил", "43", "Омерика", "157кг", "Чемпион штата")
            f2 = Karateka("Вездесущий Си", "39", "Тайвань", "89кг", "Блэк")
            f1.inf0()
            f2.inf0()
        elif i == 2:
            f1 = Boxer("Геракл", "15", "Греция", "65кг", "Чемпион школы")
            f2 = Karateka("Киоши", "13", "Япония", "49кг", "Белоснежный")
            f1.inf0()
            f2.inf0()
        else:
            f1 = Boxer("Бычий Дюк", "23", "Хорватия", "111кг", "Чемпион мира")
            f2 = Karateka("Вертлявая Задира", "Всегда 15", "Россия", "Спрашивать у дамы не прилично", "Подходит под сумочку")
            f1.inf0()
            f2.inf0()
        c=Fight()
        c.fighting(f1, f2)

def main():
    game = Menu()
    game.choose(int(game.what_prefer()))
main()
