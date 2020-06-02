# Hex to ASCII Converter
At the bootcamp, we have a series of events called Tech Talent Speed Dates (TTSD) whereby many companies come over to the academy and occupy a table where they’d interview potential candidates in 15 minute rounds.

For the first TTSD, one of the companies interviewed a fellow Full Stack student (Lukáš), and gave him a task, which he shared with us.

![The task that Lukáš slacked to me](https://images.squarespace-cdn.com/content/v1/5a9a66de8f5130e5d8f9de5c/1580293969521-VI7PKCWQFRRTTW5LZS6H/ke17ZwdGBToddI8pDm48kBDxXhGOH7JKiLGGN6Pn78V7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0luUmcNM2NMBIHLdYyXL-JzvTZQV8qcIEn0dBVPi2w6nOiQSpQMo8s3_Ix1i-cU_-A/ami_task.jpg?format=2500w)

So another Full Stack student (Ibrahim) and I had a look at it. We immediately deduced that it was a hex code puzzle, with me knowing it from my design background (Hex Colour Codes), and with Ibrahim have a computer science background. Ibrahim explained that you’d extract the value like so:

> (first digit value * 12) + (second digit value)

As Ibrahim proceeded to do the calculations on a whiteboard, I brooded for a little and began wondering if the extracted values could represent letters? i.e. each numbers has its assigned character, like ASCII.

So I googled a hex to ASCII converter, typed out the values, and then voila:           

> KOLIK PISMENEK MA NAZEV FIRMY AMI PRAHA?

> Google Translate: HOW MANY LETTERS DO THE NAME OF AMI PRAGUE HAVE?

I shared my findings with the group and then felt like making a hex to ASCII converter. 
Since I kind of had an idea of how I’d code it, I decided to do the mini project to see if it would work.

### IT WORKS!
![Successful console log](https://images.squarespace-cdn.com/content/v1/5a9a66de8f5130e5d8f9de5c/1580295067924-UBKX6POUG76NEFK92KA6/ke17ZwdGBToddI8pDm48kHRLoRAcuXBWO3O4ZhYqitcUqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYxCRW4BPu10St3TBAUQYVKcJDMAqKejz0bfPBxy62A2WRvr4_rbEUsAAMVHFRCSn_k-L8aByZFXhUWn7TBRENsb/HexToASCII_Console_Output.png?format=2500w)
