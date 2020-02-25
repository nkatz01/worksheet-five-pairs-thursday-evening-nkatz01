# Worksheet Five
## Pairs assignment - Caesar (De)Cipher

This is another exercise in *pair programming* and *Test-Driven Development*.  
This time there is a problem for you to investigate rather than a "step-by-step" process.  
As with last time, it is not the solution we are particularly focussed on but the *process*.  

Ensure you do not "pair" with the same person as you did for Worksheet Four.

## Review

In pair programming, you and your partner are both physically present and work collaboratively at one computer. 
One person is the *”driver”* and types the code into the computer. 
The other person is called the *”navigator”* and actively checks the work entered by the driver. 
Each partner spends about one-half of the time for each assignment as the driver and the other half as the reviewer. 
Together, you and your partner should discuss and implement the design, produce the code and run the tests on the code. 
Each solution must be a true joint effort equally owned, created and understood by both students.

Splitting up the assignment into parts and working on them separately is **not permitted** and violates both the letter and the spirit of the academic honesty code for this course.

## Rules of Pair Programming

+ You must work with one other student of this class, no more and no less, for the assignment.
+ When working together, you must work together physically in the same place on one computer to edit and compile code.
+ Periodically, about every fifteen minutes, change who uses the keyboard and mouse so that each partner has a chance to drive.
+ You must both turn in the same project code.

## The Problem

This problem asks you to write and test two functions (perhaps with the addition of 
*helper* functions):

```
	Encipher(s, n)
```

and

```
	Decipher(s)
```

### "Encipher"

`Encipher(s, n)` takes as input a string `s` and a non-negative integer `n` between 0 and 25. 
This function returns a new string in which the letters in `s` have been rotated by `n` characters.

For this problem you should assume that:

+ upper-case letters are “rotated” to upper-case letters, 
+ lower-case letters are “rotated” to lower-case letters, and 
+ non-alphabetic characters are left unchanged. 

For example, if we shift the letter `y` by 3, we would get `b` and if we were to shift the letter `Y` by 3 we would get `B`. 

You may write `Encipher` any way you like as long as you use recursive functions. 
You may wish to write a helper function that “rotates” a single character by `n` spots, wrapping around the alphabet as appropriate. 
Then, you might use this helper function to encipher your string. 
It’s up to you how you do this.

(**Remember**: Uppercase letters should wrap around the alphabet to uppercase letters, and lowercase letters always wrap to lowercase letters.)

### "Decipher"

`Decipher` will be given a string of English text that has already been shifted by some amount; `Decipher` should return the original English string, to the best of its ability.

**Note**: Some strings have more than one English “deciphering”. 
What’s more, it is very difficult to handle short strings correctly; your decipher does not have to be perfect.

One approach you could try is to use is [letter frequencies](https://en.wikipedia.org/wiki/Letter_frequency).
Scrabble scores have also been suggested in the past…! 
You might also want to use some additional “heuristics” (rules of thumb) of your own design. 

You are welcome to write one, or more, small ”helper” functions that will help `decipher`. 
Be sure to describe whatever strategies you used in writing your decipher function in a detailed comment above your decipher function.

### Some `encipher` examples

```
Encipher("xyza", 1)
```

results in

```
yzab
```

and

```
Encipher("Z A", 1)
```

results in

```
A B
```

Finally,

```
Encipher("Caesar cipher? I prefer Caesar salad.", 25)
```

results in

```
Bzdrzq bhogdq? H oqdedq Bzdrzq rzkzc.
```

### Some `decipher` examples

```
Decipher("Bzdrzq bhogdq? H oqdedq Bzdrzq rzkzc.")
```

results in

```
Caesar cipher? I prefer Caesar salad.
```

and

```
Decipher("Hu lkbjhapvu pz doha ylthpuz hmaly dl mvynla clyfaopun dl ohcl slhyulk.")
```

might result in

```
An education is what remains after we forget everything we have learned.
```

### Hint

For `Decipher` you might have your program “look at” all 26 possible rotations of the input string and then decide on which is “best”. 
Consider possible strategies for determining how to get a computer to determine what would be the most likely deciphered text for any given encrypted text.

[Kindergarten]: http://collaboration.csc.ncsu.edu/laurie/Papers/Kindergarten.PDF
