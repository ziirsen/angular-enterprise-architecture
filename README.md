# Angular Enterprise Architecture
---
## Runtime dependency injection with AngularJs, RequireJS and the PCI pattern

> This project aims to illustrate how to make runtime dependency injection with AngularJs and RequireJs. Core files is bundled with .NET Bundle Config, but could very well be done with other tools. The rest of the application is minified with GulpJs and injected at runtime with RequireJs.

> The project also aims to illustrates how to use the PCI javascript pattern(Parasitic Combination Inheritance) for optimal OO-programming, with the best of both worlds with the Prototype- and Constructor Stealing Pattern.

---
## Why?
The reason for this approach is that many big enterprise applications has a wide variaty of users, and their usage are in many cases very different. Some might only use a specific part of huge application while some use most of it. Lets assume they use 30% of the application, it might even be less, why should they then be presented with a full bundled javascript file, when they dont even use 70% of it, and could do with less? Also in the process reduce the data transfered from the server by 30%, 50%, or even 70% depending on the application scale and user needs and usage. 