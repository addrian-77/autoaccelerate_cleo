�  �
M ����  p�S  ����   T �
  
    � �  Ȅ M �����  9   M �����  �
WM ����   �����  9  M R����  ��WM Y���   �����  9   M �����  � M ����   �   �   �  !    �?M ����   zD   d�    �?� ����   P �����  9  M �����  ΃  M �����   �   c   �   � M q���   j���   � � � M �����       A�  !    �BM %���    �B�      C� 	  �

   �
 	   ����P ���� ����P ���� �����  9  M ����P ���� ���� d   �  Q VAR    PLAYER_ACTOR    FLAG   SRC :  {$CLEO .cs}
Alloc($PLAYER_ACTOR, 3)

if 
  Game.IsVersionOriginal
goto_if_false @Noname_30
7@ = 5503856
goto @Noname_40

:Noname_30
7@ = 5505040

:Noname_40
10@ = Memory.CallFunctionReturn(7@, 1, 1, 0)

:Noname_55
wait 0
if and
  Char.IsInAnyCar($PLAYER_ACTOR)
  not Char.IsInFlyingVehicle($PLAYER_ACTOR)
goto_if_false @Noname_558
if 
  1@ == 0
goto_if_false @Noname_127
if 
  Pad.IsKeyPressed(KeyCode.W)
goto_if_false @Noname_120
1@ = 1

:Noname_120
goto @Noname_308

:Noname_127
if 
  1@ == 1
goto_if_false @Noname_174
if 
  not Pad.IsKeyPressed(KeyCode.W)
goto_if_false @Noname_167
1@ = 2

:Noname_167
goto @Noname_308

:Noname_174
if 
  2@ == 0
goto_if_false @Noname_294
if 
  not Pad.IsButtonPressed(PadId.Pad1, Button.Cross)
goto_if_false @Noname_287
1@ = 0
0@ = Char.StoreCarIsInNoSave($PLAYER_ACTOR)
4@ = Car.GetSpeed(0@)
if 
  4@ > 1.0
goto_if_false @Noname_287
4@ += 1000.25
2@ = 1
wait 100
StuckCarCheck.Add(0@, 1.0, 500)

:Noname_287
goto @Noname_308

:Noname_294
1@ = 0
gosub @Noname_590

:Noname_308
if 
  2@ == 1
goto_if_false @Noname_551
if 
  not StuckCarCheck.IsCarStuck(0@)
goto_if_false @Noname_544
3@ = Car.GetSpeed(0@)
set_lvar_float_to_lvar_float 5@ = 4@
sub_float_lvar_from_float_lvar 5@ -= 3@
if 
  1000 > 5@
goto_if_false @Noname_398
6@ = 28
goto @Noname_405

:Noname_398
6@ = 32

:Noname_405
if and
  not Pad.IsButtonPressed(PadId.Pad1, Button.Square)
  not Pad.IsButtonPressed(PadId.Pad1, Button.Cross)
goto_if_false @Noname_530
5@ = Math.Abs()
5@ *= 10.0
if 
  5@ > 90.0
goto_if_false @Noname_474
5@ = 90.0

:Noname_474
8@ = Math.Sin(5@)
8@ *= 255.0
cset_lvar_int_to_lvar_float 9@ =# 8@
int_add 11@ = 10@ + 6@
Memory.Write(11@, 1, 9@, False)
goto @Noname_537

:Noname_530
gosub @Noname_590

:Noname_537
goto @Noname_551

:Noname_544
gosub @Noname_590

:Noname_551
goto @Noname_583

:Noname_558
if 
  2@ == 1
goto_if_false @Noname_583
gosub @Noname_590

:Noname_583
goto @Noname_55

:Noname_590
wait 100
2@ = 0
StuckCarCheck.Remove(0@)
return 
a  __SBFTR 