  GZG[G\G]G^G_G`GaGtGcGdGeGfGgGhGiGjЛ ZР
M І€€€Р
M І€€€ Ж€€€     ƒ       @@√х®Њ
   O( d,  2 2d, G  ЛЪ   
   ( З( , e,   е	TEXT  exР
M ъю€€ юь€€Р
?M ию€€ ƒю€€Р
M ÷ю€€ yь€€Р
M €€€ Mэ€€  
   9   M §ю€€ №э€€9   *M Пю€€ ќэ€€9   AM zю€€ јэ€€9   JM eю€€ iэ€€9   VM Pю€€ ≤э€€9   wM ;ю€€ [э€€9   Х M %ю€€ §э€€9   – M ю€€ Хэ€€9   	M щэ€€ Жэ€€9    M гэ€€ wэ€€ [€€€   	 [€€€   + [€€€   B [€€€   W [€€€   Ц  [€€€   —  [€€€    [€€€    [€€€   K [€€€   x [€€€  d, ѓ , @	, P(  1, ( Ћ( #( фв( K(   ЦB M€€€ 
≤(  p иь€€ 
Р
M “ь€€ Ѓь€€Р
M јь€€ yь€€Р
?M иь€€ Mэ€€ d
  9  &M Оь€€ Зь€€ юь€€    юь€€  #( фЦ( ¬( d,  І€€€VAR    ONMISSION Ш  PLAYER_ACTOR    PLAYER_CHAR    PLAYER_GROUP    SECOND_PLAYER Ъ   FLAG    SRC ”  {$CLEO .cs}

0000: NOP
0247: load_model 346 
0247: load_model 347
0247: load_model 348 
0247: load_model 349
0247: load_model 350 
0247: load_model 351
0247: load_model 352 
0247: load_model 353 
0247: load_model 372 
0247: load_model 355
0247: load_model 356 
0247: load_model 357
0247: load_model 358 
0247: load_model 359
0247: load_model 360 
0247: load_model 361
0247: load_model 362  
038B: load_requested_models 

:WACHT
0001: wait 90
0A90: is_hid_pressed 15
004D: jump_if_false @WACHT 
0A90: is_hid_pressed 16
004D: jump_if_false @WACHT
0002: jump @START

:START
0006: 1@ = 22
0006: 0@ = 7

04C4: store_coords_to 10@ 20@ 30@  from_actor $PLAYER_ACTOR with_offset 0.0 3.0 -0.33 

:ADD
034F: destroy_actor_with_fade $10 
0164: disable_marker $11
0001: wait 50
:ADD2
0001: wait 50
0164: disable_marker $11
0247: load_model 0@ 
038B: load_requested_models
009A: $10 = create_actor_pedtype 2 model 0@ at 10@ 20@ 30@ 
0187: $11 = create_marker_above_actor $10 
0165: set_marker $11 color_to 2 

:ACTION0
0001: wait 0
03E5: show_text_box 'TEXT'
//01E3: show_text_1number_styled GXT '~b~Ped ID ' number 0@ time 50 style 1 
0A90: is_hid_pressed 13
004D: jump_if_false @VOL
0002: jump @WEPUP
:VOL 
0A90: is_hid_pressed 63
004D: jump_if_false @VOL1 
0002: jump @NEXT
:VOL1  
0A90: is_hid_pressed 12
004D: jump_if_false @VOL2 
0002: jump @ENDE
:VOL2  
0A90: is_hid_pressed 14
004D: jump_if_false @ACTION0
0002: jump @JOIN 


:NEXT 
0001: wait 0
000A: 0@ += 1
0039: 0@ == 8 
004D: jump_if_false @WHY
0002: jump @FAILSAVE
:WHY 
0039: 0@ == 42
004D: jump_if_false @WHY1
0002: jump @FAILSAVE1
:WHY1
0039: 0@ == 65
004D: jump_if_false @WHY2
0002: jump @FAILSAVE2 
:WHY2
0039: 0@ == 74
004D: jump_if_false @WHY10
0002: jump @FAILSAVE9
:WHY10  
0039: 0@ == 86
004D: jump_if_false @WHY3
0002: jump @FAILSAVE3 
:WHY3
0039: 0@ == 119
004D: jump_if_false @WHY8
0002: jump @FAILSAVE10 
:WHY8
0039: 0@ == 149
004D: jump_if_false @WHY4
0002: jump @FAILSAVE4 
:WHY4
0039: 0@ == 208
004D: jump_if_false @WHY5
0002: jump @FAILSAVE5 
:WHY5
0039: 0@ == 265
004D: jump_if_false @WHY6
0002: jump @FAILSAVE6 
:WHY6
0039: 0@ == 288
004D: jump_if_false @WHY7
0002: jump @FAILSAVE7 
:WHY7
0002: jump @ADD

:FAILSAVE
0006: 0@ = 9
0002: jump @ADD

:FAILSAVE1
0006: 0@ = 43
0002: jump @ADD

:FAILSAVE2
0006: 0@ = 66
0002: jump @ADD

:FAILSAVE3
0006: 0@ = 87
0002: jump @ADD

:FAILSAVE4
0006: 0@ = 150
0002: jump @ADD

:FAILSAVE5
0006: 0@ = 209
0002: jump @ADD

:FAILSAVE6
0006: 0@ = 274
0002: jump @ADD

:FAILSAVE7
0006: 0@ = 7
0002: jump @ADD

:FAILSAVE9
0006: 0@ = 75
0002: jump @ADD

:FAILSAVE10
0006: 0@ = 120
0002: jump @ADD

:JOIN
0001: wait 0 
0164: disable_marker $11 
07AF: $PLAYER_GROUP = player $PLAYER_CHAR group 
0940: set_group $PLAYER_GROUP enters_leaders_vehicle 1 
0850: AS_actor  $10 follow_actor $PLAYER_ACTOR 
0631: put_actor $10 in_group $PLAYER_GROUP
07CB: set_actor $10 supporting_fire 1
0223: set_actor $10 health_to 500
02E2: set_actor $10 weapon_accuracy_to 75
060F: set_actor $10 melee_accuracy_to 75.0
 0002: goto @ADD2   

:WEPUP
0001: wait 10 
01B2: give_actor $10 weapon 1@ ammo 6000 // Load the weapon model before using this 
0002: jump @CHOOSE

:CHOOSE
0001: wait 10
//00BC: print_now '~b~Press Up To Change Weapons ~g~Press Right To Join ~r~Press Down To Remove' time 50 flag 1
0A90: is_hid_pressed 13
004D: jump_if_false @VOL8 
0002: jump @WEPUP1
:VOL8 
0A90: is_hid_pressed 12
004D: jump_if_false @VOL9 
0002: jump @ENDE
:VOL9  
0A90: is_hid_pressed 63
004D: jump_if_false @CHOOSE
0002: jump @JOIN

:WEPUP1
wait 100
000A: 1@ += 1
0039: 1@ == 38 
004D: jump_if_false @WHY9
0002: jump @FAILSAVE8
:WHY9
0002: jump @WEPUP

:FAILSAVE8
0006: 1@ = 0
0002: jump @WEPUP 

:ENDE  
0001: wait 0
0223: set_actor $10 health_to 500  
0296: set_char_heed_threats $10 flag 1
01C2: remove_references_to_actor $10 
0164: disable_marker $11
0002: jump @WACHT©  __SBFTR 