   M S B A M L   `   `   `  ????G  Cgeldautomaat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:geldautomaat.Windowsgeldautomaat.Windows  5   	   "    geldautomaat.Windows.opnemen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:geldautomaat.Windows     5   	     ? Title$  opnemen??5   	   $	??650??6   $	??900??6&   .??5	      ? ???#6d6d6d ? RowDefinitions 5
   
   ?? 5      $	??34* ?6   6+   ?? 5      $	??44* ?6   6+   ?? 5      $	??44* ?6   6+   ?? 5      $	??44* ?6   6+   ?? 5      $??9* ?6   6*   ?? 5      $	??25* ?6   6+   ?? 5      $	??25* ?6   6+   ?? 5      $	??25* ?6   6+   ?? 5      $	??25* ?6   6+   ?? 5      $??9* ?6   6*    ? ColumnDefinitions 5   
   ?? 5      $??9* ?6   ?? 5      $	??72* ?6   ?? 5      $	??16* ?6   ?? 5      $	??65* ?6   ?? 5      $	??82* ?6   6-   ?? 5      $	??82* ?6   6-   ?? 5       $	??82* ?6   6-   ?? 5!      $	??82* ?6   6-   ?? 5"      $	??82* ?6   6-   ?? 5#      $	??82* ?6   6-   ?? 5$      $	??82* ?6   6-   ?? 5&      $	??82* ?6   6-   ?? 5'      $	??82* ?6   6-   .+?5*   
   ?? $??7??6   $??4??6(   $??5??68   
???   ?
???????$??	0,62,0,20q?6f   ?? 5+   
   -   5        $??btnback??5+      $?? ??6   $??1??6,   $??1??6<   $??3??6I   $??18,21,14,22q?6]   $??55??6r   ?? 5,   
   -   5        $??btnATM2??5,   n   $?? ??6   $??1??6   $??2??6,   $??3??69   $??18,21,14,22q?6M   $??55??6b   6n   ?? 5-   
   -   5        $??btnATM3??5-   o   $?? ??6   $??1??6   $??3??6,   $??3??69   $??55??6N   $??18,22,14,22q?6Z   6o   ?? 5.   
   -   5        $??btnATM4??5.   o   $?? ??6   $??11??6   $??1??6-   $??2??6:   $??27,21,14,22q?6N   $??55??6c   6o   ?? 5/   
   -   5        $??btnATM6??5/   o   $?? ??6   $??11??6   $??3??6-   $??2??6:   $??27,21,14,23q?6N   $??55??6c   6o   ?? 50   
   -   5        $??btnATM5??50   B   $?? ??6   $??11??6   $??27,21,14,22q?6-   $??2??6Q   $??2??6^   $??55??6s   ?? 51   
   -   5        $??btnOne??51   ;   $??1??6   $??40(?6   $??6??6+   $??5??6J   $??2??6W   $??	0,0,81,55q?6k   $??2??6~   ?? 52   
   -   5        $??btnThree??52   ;   $??3??6   $??40(?6   $??7??6+   $??5??6L   $??2??6Y   $??	81,0,0,55q?6m   $??2??6?   ?? 53   
   -	   5        $??btnTwo??53   ;   $??2??6   $??40(?6   $??7??6+   $??5??6J   $??0,0,0,55q?6W   $??2??6i   ?? 54   
   -
   5        $??btnFour??54   ;   $??4??6   $??40(?6   $??6??6+   $??6??6J   $??2??6W   $??0,0,81,0q?6k   ?? 55   
   -   5        $??btnSix??55   H   $??6??6   $??40(?6   $??7??6+   $??6??6;   $??2??6W   $??81,0,0,0q?6k   ?? 56   
   -   5        $??btnfive??56   ;   $??5??6   $??40(?6   $??7??6+   $??6??6K   ?? 57   
   -   5        $??btnSeven??57   I   $??7??6   $??40(?6   $??6??6+   $??6??6<   $??2??6Y   $??	0,55,81,0q?6m   $??2??6?   ?? 58   
   -   5        $??btnEight??58   I   $??8??6   $??40(?6   $??7??6,   $??6??6<   $??0,55,0,0q?6Y   $??2??6k   ?? 59   
   -   5        $??btnNine??59   I   $??9??6   $??40(?6   $??7??6,   $??6??6<   $??2??6X   $??	81,55,0,0q?6l   $??2??6   ?? 5:   
   -   5        $??btnZero??5:   I   $??0??6   $??40(?6   $??7??6,   $??7??6<   $??	0,56,0,20q?6X   $??3??6k   ?? 5;   
   -   5        $??btnEnter??5;   ?   $??enter??6   $??30(?6!   $??10??6/   $
??Left=?6@   $??10 0 0 0q?6b   $??6??6u   $??2??6?   ?? 5<   
   
???   ?$??11??6#   $??50??65   $??30??6@   
??? ? ?$??6??6Y   ?? 5=   
   -   5        $??	btnCancel??5=   ?   $??cancel??6   $??30(?6"   $??10??60   $
??Left=?6A   
???????$??10 0 0 0q?6v   $??7??6?   $??2??6?   ?? 5>   
   
???   ?$??11??6#   $??50??65   $??30??6@   
???  ??$??7??6W   ?? 5?   
   -   5        $??lbOp2??5?      $??Center=?6   $??Center=?6;   $	??200??6V   $??4??6d   $??2??6t   $??30(?6?   $??2??6?   ?? 5@   
   -   5        $??lbOp3??5@      $??Center=?6   $??Center=?6;   $	??400??6V   $??4??6d   $??3??6t   $??30(?6?   $??2??6?   ?? 5A   
   -   5        $??lbOp4??5A      $??Center=?6   $??Center=?6;   $	??100??6V   $??9??6d   $??1??6t   $??30(?6?   $??2??6?   ?? 5B   
   -   5        $??lbOp5??5B      $??Center=?6   $??Center=?6;   $	??300??6V   $??9??6d   $??2??6t   $??30(?6?   $??2??6?   ?? 5C   
   -   5        $??lbOp6??5C      $??Center=?6   $??Center=?6;   $	??500??6V   $??9??6d   $??3??6t   $??30(?6?   $??2??6?   ?? 5E   
   -   5        $	??lb1??5E   G   $??opnemen??6   $??Center=?6"   $??30(?6S   $??6??6a   $??4??6q   $??1??6?   $??0,0,63,0q?6?   ?? 5F   
   -   5        $	??rg2??5F      $??5??6   $??5??63   $y?Hidden=?6C   $??1??6W   $??1??6d   
???   ?$??1??6?   
???????6?   ?? 5G   
   -   5        $??rcAmount??5G      $y?Hidden=?6    $??wilt u 500 pinnen??64   $??6??6P   $??1??6`   $??Center=?6m   $??Center=?6?   $??3??6?   $??25(?6?   ?? 5H   
   $??Center=?6   $??Center=?6/   $
??back??6J   $??4??6Y   $??1??6i   $??30(?6v   $??2??6?   ?? 5I   
   -   5         ??Name$ lbOpgenomen??5I   @   $?? ??6   $??Center=?6   $??20(?6V   $??6??6d   $??4??6t   $??2??6?   $??0,0,63,0q?6?   5J      5K      