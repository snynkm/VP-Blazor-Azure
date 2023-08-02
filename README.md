# Pizza Ordering Application (Demo)

<h3>Demo Link: <a href="https://vennatospizza.azurewebsites.net/">Visit My Project Demo at Vennato's Pizza Website</a> </h3>

Application Name: Vennato's Pizza

<h3>Table of Contents:</h3>
<ul>
  <li>List Item 1</li>
  <li>List Item 2</li>
  <li>List Item 3</li>
</ul>

<h3>Summary:</h3>
This is my first full-stack application project which is a demo Pizza Ordering Application. I wanted to create a website similar to company websites like Domino's and Little Caesars, where the user can check out menu items and order online. 

<table>
  <tr>
    <th><b>Technologies:</b></th>
    <td>
        <ul>
        <li><b>Front-End:</b> HTML | CSS | MudBlazor</li>
        <li><b>Back-End (Server-Side Web App Dev Tools):</b> Blazor Server | Dapper ORM</li>
        <li><b>Back-End (Database):</b> Azure SQL Database | MS SQL Server</li>
        <li><b>IDEs:</b> Visual Studio | SSMS </li>
        <li><b>Version Control:</b> Git</li>
        <li><b>Hosting Service</b> GitHub</li>
        <li><b>PaaS:</b> Azure Web Apps & App Service</li>
        <li><b>PM:</b> Trello</li>
      </ul>
    </td>
  </tr>
  <tr>
    <th><b>Additional Tools:</b></th>
    <td>
        <ul>
        <li><b>Image Compression:</b> <a href="https://tinypng.com/">TinyPNG</a> </li>
        <li><b>ERD Visualization: </b> <a href="https://www.mural.co/">Mural</a> </li>
        <li><b>RGB/Hex Code Selector:</b> <a href="https://www.rapidtables.com/web/color/RGB_Color.html">RapidTables</a>  </li>
        <li><b>Logo Generator:</b> <a href="https://cooltext.com/">Cooltext</a> </li>
      </ul>  
    </td>
  </tr>
  <tr>
    <th><b></b></th>
    <td></td>
  </tr>
</table>



<h3>Background:</h3>
<p>
  I started my developer journey back in November 2022, spending the first few months self studying the fundamentals of C# and labbing stuff out in the Console App, Winforms, and simple MVC CRUD application. After a few months of getting familiar with the basics, I decided to try my hand at developing a full stack application while sticking with ASP.NET technologies. This has by far been the biggest jump in challenge for me and one that I was ambitious to take on. At the time, I had done much research to discover some of the in-demand .NET technologies out there, such as Blazor, EF Core, Razor Pages, etc. I ultimately decided to go with Blazor Server for this project because I felt intrigued by what Signal R has to offer. I also feel that the Blazor framework is Microsoft flagship product and their primary focus.
</p>

<p>
  Regarding the project's theme, I wanted to keep it simple - develop a Pizza App. I chose this idea because of a couple reason. Firstly, I didn't know what else to think of. As a new developer, I didnt have the experience to come up with a sophisticated idea that solves a specific business problem. The latter reason more importantly, I felt that going with a Pizza App is something that many people are familiar with. My goal wasn't to oversell on the project idea, but to instead focus within the application and make sure to include certain features and enhancements that really draw out a smooth user experience (hopefully). 
</p>

<p>
  To sum it up, the project was definitely a grind but also something I found to be very rewarding. In terms of technicality, the project itself is nowhere near perfect. There were several things I felt could have been improved upon but due to time constraints I wasn't able to restructure. That being said, I still learned a lot and had tons of fun developing it. To name a few, my favorite parts while developing this application were coming up with the product names, figuring out the pricing, coming up with architectural UX/UI designs, and implementing creative solutions to find workarounds.
</p>

<h3>Features:</h3>
<ul>
<li>Product Catalog</li>
<li>Shopping Cart</li>
<li>Checkout Process/Order Submission</li>
<li>Business Analysis</li>
</ul>

Here are the menu items we are adding to the order:
<img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/f74a0136-c3de-4e13-9843-91b6a885b5bf" alt="Menu" width="800">
<img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/c6af9f3d-b916-4da6-ade8-126eab628371" alt="AddItem" width="400">
<img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/73a230d0-917e-435e-bf94-5a72ced51c70" alt="Summary" width="400">

Viewing the normalized data after order submission:
<img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/0489fd63-221d-41e8-ae0c-fc843dbf5673" alt="Normalized Data" width="800">

What items were included in this order?


<img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/7c530dff-650f-403c-9342-5c82cc27ac24" alt="MenuItem Lookup" width="500">

What toppings were included with each item?
<img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/383e8234-2a0a-43ff-b79b-6a1613a05ad2" alt="Full MenuItem Lookup" width="500">

With this database structure, and the ability to link these tables, from there you can perform more complex queries to solve business questions such as (1) What's the most popular menu item of X month? (2) Which states had more carryout orders vs delivery? (3) What was the average item count per order?

<h3>Steps:</h3>

<h3>Eureka Moments:</h3>
<ul>
  <li>Understanding Component Life Cycles</li>
  <li>Learning about Shared State</li>
  <li>Finding out what a DTO is midway through the application</li>
  <li>Finally getting a grasp on Dependency Injection</li>
  <li>Developing the project to scale</li>
</ul>

<h3>Helpful Resources:</h3>




