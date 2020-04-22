# Companion Bot

The Bot is a console application which you can send messages to and it will respond in a companion-like manner.

Build its response iteratively using TDD. The four commands that the user can enter are in bold. 

## Commands

### 1 Hello
The bot will respond with a response of  
``Hello``

### 2 Mynameis *name*
The bot will respond with a response of  
``Hello *name*``

Once the bot has learned the user's name it will use it in any interactions

### 3 HappyMe
The bot will respond with a response of   
``Have a great day today *name*!``

### 4 Happier
The bot will respond with one of four responses:

``You are looking great today *name*``  
``You had a great day yesterday *name*. Keep it going!``   
``Winners keep trying``   
``Always look on the bright side of life!``

The response returned will be a random one but must be returned in as equal a distribution as possible.  I.e.:
- if there have 8 responses, there must have been two of each. 
- if there have 11 responses, there must have been no more than three of any (and no less than two of any). 

## Review

- What errors can arise?
- Where are there gaps in the spec?
