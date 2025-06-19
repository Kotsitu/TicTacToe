# TicTacToe
TicTacToe Game<br>
# BGN/Български
<br>
В играта морски шах се играе от двама души или от човек и робот.

Тя се играе с два символа "Х", "О".<br>
Играта се играе на 3х3 поле, в което три последователно свързани едни и същи символа печелиш играта.<br>


# Ръководство на потребителя
За да стартирате програмата изтеглете прикачения файл под форма .zip файлово разширение, след това като ви се изтегли го разархивирате в удобна за вас папка.
Влизате в проекта от него папка Properties, там ще видите TicTacToe.exe стартирате го..
Готови сте да играете!
# Ръководство на програмиста / Как е направена?
Кода е отворен, достъпен, което позволява лесно редактиране, подобрение и адаптиране според нуждите на теглещия. 
Играта в прикачения файл е направен на WIN forms (Visual Studio 2022).<br>
С 10 бутона, които 1 е <b>Reset</b> бутон а останалите вършат работа като празни полета за морския шах.
Създаваме глобална булева променлива, в полза на това, че ще я използваме като флаг показвайки дали е реда на Х. (isXTurn)
в следния код:
if (button1.Text != "") return; 

button1.Text = isXTurn ? "X" : "O";
button1.Enabled = false;
if (CheckWinner())
{
    label2.Text = (isXTurn ? "X" : "O") + " wins!";
    DisableAllButtons();
}
else if (IsDraw())
{
    label2.Text = "Draw!";
}
else
{
    isXTurn = !isXTurn;
    label2.Text = (isXTurn ? "X" : "O") + "'s turn";
}
Показан е кода за button1 ("празното поле"), ако  бутона е празен сложи текст Х или О според булевата променлива.
То тогава щом бутона е натиснат да се деактивира.

<h2><b>Минималните системни изисквания на тази игра са следните:</b></h2><br>
OS/Операционна система<br> 
* Windows 10 x64 bit<br>
CPU/Процесор <br>
* Intel Core i7 8650U @ 1.90GHz <br>
RAM <br>
* 8GB <br>
Storage/Място<br>
* 1.13 MB<br>
GPU/Видео карта<br>
* UHD Graphics 620<br>

 # ENG/English
 <br>
The game of sea chess is played by two people or by a person and a robot.<br>
It is played with two symbols "X", "O".<br>
The game is played on a 3x3 field, in which three consecutively connected identical symbols win the game.<br>
The game in the folder is made on WIN forms (Visual Studio 2022).<br>

<h2><b>The minimum system requirements for this game are as follows:</b></h2>
OS/Operating system<br>
* Windows 10 x64 bit<br>
CPU/Processor<br>
* Intel Core i7 8650U @ 1.90GHz<br>
RAM<br>
* 8GB<br>
Storage/Space <br>
* 1.13 MB<br>
GPU/Video card<br>
* UHD Graphics 620<br>
