TITLE LAB6 (.EXE MODEL)
;-------------------------------------------------------------------------------
STACKSEG SEGMENT PARA 'Stack'
STACKSEG ENDS
;-------------------------------------------------------------------------------
DATASEG SEGMENT PARA 'Data'
    A_CHAR DB 'A$'
    POINTER DB 15
    X_POS DB 01
    Y_POS DB 05
    UP_ARROW DB 48H
    RIGHT_ARROW DB 4DH
    DOWN_ARROW DB 50H
    LEFT_ARROW DB 4BH
    ESC_KEY DB 1BH
    INPUT_DATA DW ?
    T1 DB " ::::::::   ::::::::  ::::    :::  ::::::::  :::    ::: :::::::::: ::::::::: ", 10, 13, "$"
    T2 DB " :+:    :+: :+:    :+: :+:+:   :+: :+:    :+: :+:    :+: :+:        :+:    :+: ", 10, 13, "$"
    T3 DB " +:+        +:+    +:+ :+:+:+  +:+ +:+    +:+ +:+    +:+ +:+        +:+    +:+ ", 10, 13, "$"
    T4 DB " +#+        +#+    +:+ +#+ +:+ +#+ +#+    +:+ +#+    +:+ +#++:++#   +#++:++#:  ", 10, 13, "$"
    T5 DB " +#+        +#+    +#+ +#+  +#+#+# +#+  # +#+ +#+    +#+ +#+        +#+    +#+ ", 10, 13, "$"
    T6 DB " #+#    #+# #+#    #+# #+#   #+#+# #+#   +#+  #+#    #+# #+#        #+#    #+# ", 10, 13, "$"
    T7 DB "  ########   ########  ###    ####  ###### ### ########  ########## ###    ### ", 10, 13, "$"
    ;T8 DB "                              PLAY GAME", 10, 13, '$'
    T9 DB "                            Press any key to continue", 10, 13, '$'
    ;TA DB "                              HIGH SCORE", 10, 13, '$'
    POINT DB ">$"
    H1 DB "         _   _  _____        __  _____ ___    ____  _        _ __   __" , 10, 13, "$"                
    H2 DB "         | | | |/ _ \ \      / / |_   _/ _ \  |  _ \| |      / \\ \ / /" , 10, 13, "$"
    H3 DB "         | |_| | | | \ \ /\ / /    | || | | | | |_) | |     / _ \\ V / " , 10, 13, "$"
    H4 DB "         |  _  | |_| |\ V  V /     | || |_| | |  __/| |___ / ___ \| |  " , 10, 13, "$"
    H5 DB "         |_| |_|\___/  \_/\_/      |_| \___/  |_|   |_____/_/   \_\_|  " , 10, 13, "$"

    H6 DB "                            Use the arrow keys to move", 10, 13, "$"
    H7 DB "                              and collect all coins",10, 13, "$"

    G1 DB "                    _|_|_|    _|_|    _|      _|  _|_|_|_|      ", 10, 13, "$"  
    G2 DB "                   _|        _|    _|  _|_|  _|_|  _|            ", 10, 13, "$"
    G3 DB "                   _|  _|_|  _|_|_|_|  _|  _|  _|  _|_|_|        ", 10, 13, "$"
    G4 DB "                   _|    _|  _|    _|  _|      _|  _|            ", 10, 13, "$"
    G5 DB "                     _|_|_|  _|    _|  _|      _|  _|_|_|_|      ", 10, 13, "$"
    G6 DB "                                                                ", 10, 13, "$"
    G7 DB "                                                                ", 10, 13, "$"
    G8 DB "                     _|_|    _|      _|  _|_|_|_|  _|_|_|        ", 10, 13, "$"
    G9 DB "                   _|    _|  _|      _|  _|        _|    _|      ", 10, 13, "$"
    G10 DB "                   _|    _|  _|      _|  _|_|_|    _|_|_|        ", 10, 13, "$"
    G11 DB "                   _|    _|    _|  _|    _|        _|    _|      ", 10, 13, "$"
    G12 DB "                     _|_|        _|      _|_|_|_|  _|    _|      ", 10, 13, "$"

                             
                                   
                               
                                  
                              
                                                                      
                                                                      
                                                                      
                                 
                            
                             
                           
                         
                                         
                                                                          
                                                                                   
       



DATASEG ENDS
;-------------------------------------------------------------------------------
CODESEG SEGMENT PARA 'Code'
    ASSUME SS:STACKSEG, DS:DATASEG, CS:CODESEG

    START:
        MOV AX, DATASEG
        MOV DS, AX

MAIN PROC FAR

    CALL DISPLAY_MENU


    CALL DISPLAY_GAME_OVER

    TERMINATE:
    MOV AH, 4CH
    INT 21H

MAIN ENDP
;------------ DISPLAYS THE TITLE SCREEN AND HOW-TO-PLAY SCREEN-----------
DISPLAY_MENU PROC NEAR

    ANIMATION:

    CALL CLEAR_SCREEN
    MOV DL, 00H
    MOV DH, 00H
    ;set cursor
    MOV AH, 02H   ;function code to request for set cursor
    MOV BH, 00    ;page number 0, i.e. current screen
    MOV DH, Y_POS    ;set row
    MOV DL, X_POS    ;set column
    INT 10H
    ;color scheme
    MOV AX, 0600H   ;full screen
    MOV BH, 0CH     ;light red
    MOV CX, 0500H   ;upper left row:column 
    MOV DX, 064FH   ;lower right row:column 
    INT 10H
    ;text
    LEA DX, T1
    CALL PRINT
    LEA DX, T2
    CALL PRINT
    ;color
    MOV AX, 0600H   
    MOV BH, 0EH     ;yellow
    MOV CX, 0700H   
    MOV DX, 0A4FH   
    INT 10H
    ;color
    MOV AX, 0600H   
    MOV BH, 0CH     
    MOV CX, 0B00H   
    MOV DX, 0C4fH   
    INT 10H
    ;text
    LEA DX, T3
    CALL PRINT
    LEA DX, T4
    CALL PRINT
    LEA DX, T5
    CALL PRINT
    LEA DX, T6
    CALL PRINT
    LEA DX, T7
    CALL PRINT
    ;set cursor
    MOV AH, 02H   
    MOV BH, 00    
    MOV DH, 15    
    MOV DL, 0   
    INT 10H
    ;color
    MOV AX, 0600H   
    MOV BH, 0EH     
    MOV CX, 0F00H   
    MOV DX, 184FH  
    INT 10H
    ;text
    LEA DX, T9
    CALL PRINT
    ;set cursor
    MOV AH, 02H   
    MOV BH, 00    
    MOV DH, 19    
    MOV DL, 40   
    INT 10H
    ;key input
    MOV      AH, 10H             
    INT     16H
    MOV     AX, 0003H
    INT     10H
    
    ;new screen for game instructions
    CALL CLEAR_SCREEN
    MOV DL, 00H
    MOV DH, 00H
    ;set cursor
    MOV AH, 02H  
    MOV BH, 00    
    MOV DH, Y_POS    ;
    MOV DL, X_POS    
    INT 10H
    ;color
    MOV AX, 0600H   
    MOV BH, 0CH    
    MOV CX, 0500H   
    MOV DX, 094FH   
    INT 10H
    ;display
    LEA DX, H1
    CALL PRINT
    LEA DX, H2
    CALL PRINT   
    LEA DX, H3
    CALL PRINT
    LEA DX, H4
    CALL PRINT
    LEA DX, H5
    CALL PRINT
    ;cursor
    MOV AH, 02H   ;function code to request for set cursor
    MOV BH, 00    ;page number 0, i.e. current screen
    MOV DH, 15    ;set row
    MOV DL, 0    ;set column
    INT 10H
    ;color   
    MOV AX, 0600H   
    MOV BH, 0EH    
    MOV CX, 0F00H   
    MOV DX, 104FH   
    INT 10H
    ;text
    LEA DX, H6
    CALL PRINT
    LEA DX, H7
    CALL PRINT
    ;cursor
    MOV AH, 02H   ;function code to request for set cursor
    MOV BH, 00    ;page number 0, i.e. current screen
    MOV DH, 20    ;set row
    MOV DL, 0    ;set column
    INT 10H
    ;color  
    MOV AX, 0600H   
    MOV BH, 0CH    
    MOV CX, 1400H   
    MOV DX, 184FH   
    INT 10H
    LEA DX, T9
    CALL PRINT
    ;set cursor
    MOV AH, 02H   ;function code to request for set cursor
    MOV BH, 00    ;page number 0, i.e. current screen
    MOV DH, 21    ;set row
    MOV DL, 40    ;set column
    INT 10H
    ;key input
    MOV      AH, 10H             
    INT     16H
    MOV     AX, 0003H
    INT     10H

RET
DISPLAY_MENU ENDP
;-------------------------------------------------------------------
DISPLAY_GAME_OVER PROC NEAR

    CALL CLEAR_SCREEN
    MOV DL, 00H
    MOV DH, 00H
    ;set cursor
    MOV AH, 02H  
    MOV BH, 00    
    MOV DH, Y_POS    ;
    MOV DL, X_POS    
    INT 10H
    ;color
    MOV AX, 0600H   
    MOV BH, 0CH    
    MOV CX, 0500H   
    MOV DX, 104FH   
    INT 10H
    ;display
    LEA DX, G1
    CALL PRINT
    LEA DX, G2
    CALL PRINT   
    LEA DX, G3
    CALL PRINT
    LEA DX, G4
    CALL PRINT
    LEA DX, G5
    CALL PRINT
    LEA DX, G6
    CALL PRINT
    LEA DX, G7
    CALL PRINT
    LEA DX, G8
    CALL PRINT
    LEA DX, G9
    CALL PRINT
    LEA DX, G10
    CALL PRINT
    LEA DX, G11
    CALL PRINT
    LEA DX, G12
    CALL PRINT

    ;set cursor
    MOV AH, 02H   ;function code to request for set cursor
    MOV BH, 00    ;page number 0, i.e. current screen
    MOV DH, 21    ;set row
    MOV DL, 40    ;set column
    INT 10H

    MOV     AH, 10H             
    INT     16H
    MOV     AX, 0003H
    INT     10H
   
    RET

DISPLAY_GAME_OVER ENDP
;-------------------------------------------------------------------
_GET_KEY	PROC	NEAR
			MOV		AH, 01H		;check for input
			INT		16H

			JZ		__LEAVETHIS

			MOV		AH, 00H		;get input	MOV AH, 10H; INT 16H
			INT		16H

            MOV     INPUT_DATA, AX

	__LEAVETHIS:
			RET
_GET_KEY 	ENDP
;--------------------------------------------------------------------
;--display--
CLEAR_SCREEN PROC NEAR
    MOV AX, 0600H   ;full screen
    MOV BH, 0FH     ;white background (1), blue foreground (0)
    MOV CX, 0000H   ;upper left row:column (1:1)
    MOV DX, 184FH   ;lower right row:column (23:78)
    INT 10H
  RET
CLEAR_SCREEN ENDP

;------------------------------------------------------------------
;--print-char-at-cursor--
PRINT PROC NEAR
    MOV AH, 09
    INT 21H
    RET
PRINT ENDP


;----------------------------------------------------------------------
_DELAY PROC	NEAR
			mov bp, 2 ;lower value faster
			mov si, 2 ;lower value faster
		delay2:
			dec bp
			nop
			jnz delay2
			dec si
			cmp si,0
			jnz delay2
			RET
_DELAY ENDP

CODESEG ENDS
END START
