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
  Regarding the project's theme, I wanted to keep it simple - develop a Pizza App. I chose this idea because of a couple reason. Firstly, I didn't know what else to think of. As a new developer, I didnt have the experience to come up with a sophisticated idea that solves a specific business problem. The latter reason more importantly, I felt that going with a Pizza App is something that many people are familiar with. My goal wasn't to oversell on the project idea, but to instead focus within the application and make sure to include certain features and enhancements that really draw out a smooth user experience (hopefully). 
</p>

<p>
  To sum it up, the project was definitely a grind but also something I found to be very rewarding. In terms of technicality, the project itself is nowhere near perfect. There were several things I felt could have been improved upon but due to time constraints wasn't able to restructure. That being said, I still learned a lot and had tons of fun developing it. To name a few, my favorite parts while developing this application were coming up with the product names, figuring out the pricing, coming up with architectural UX/UI designs, and implementing creative solutions to find workarounds.
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

With this database structure, and the ability to link these tables, from there you can perform more complex queries to solve business questions such as (1) What's the most popular item of X month? (2) Which states had more carryout orders vs delivery? (3) What was the average item count per order?

<h3>Steps:</h3>

<h3>Eureka Moments:</h3>
<ul>
  <li>
    <b>Understanding Component Life Cycles</b> -
    <p>I started to understand this concept when trying to display object properties in different components (such as OrderItem, Customer, Branch, etc.). I was first attempting to put them all as component properties and have them inherited. However, during testing I kept running into issues of objects being set to null which kept crashing my app. I didn't know why this was happening until I found out that component properties are essentially tied to their respective life cycles. This means they are temporary and reset once the cycle finishes which happens when you navigate away from the component (if I understand correctly). Around the same time, I also found out about Share State and what it does. So together with those two concepts in mind, I had to ask myself, <i> which object should I initialize directly in the component vs in the Shared State? </i> I basically boiled it down into one thing, <i>Does the initalized object need to change during the app session (two way binded) or does it not need to change (one way bind)? </i> Objects such as Customer need to change because, i.e. a customer needs to input their First and Last name. Inversely, objects such as State doesn't have to change because a State name (i.e. Massachusetts) doesn't typically change. So for all changed data, I initialized in the Shared State and for non-changing data, I kept in the locally component.</p>
  </li>
  <li>
    <b>Learning about Shared State</b>
    <p>
      At this point of the project, I was now starting on the Checkout order process.
      - components need to share data 
      - 
      - 
    </p>
  </li>
  <li>
    <b>Finding out what a DTO is midway through the project</b>
    <p>
      While working on the checkout process, I needed to find a way to package the session data to be inserted back into the database. After watching some videos, I stumble across the principle of Data Transfer Objects (DTOs). This was a huge concept that I think would've made the project easier if I had learned it at the beginning. It's basically a custom class object (above the data access layer) that groups only pertinant data from a class that the user needs to see. With this concept, I was present a fork in the road, <i>should I restructure the application to use DTOs, or should I proceed with the current setup?</i> Although the current setup was working fine, I ultimately decided to restructure the application. This was one of the biggest changes I made on the project. And since this change involved restructuring every project (database, class library and webapp), I ended up creating some sort of unit test first, where I made a simple version of the current solution, involving only the relevant classes, models and components that were tied to this change. I tested the solution to make sure it works and then slowly began restructuring my current solution based on the test solution. In restrospect, I think this change was necessary. It made some of my components cleaner and easier to read/write. I was also able to clean up my database structure and also got good experience being able to create a new solution a lot quicker. 

    </p>
  </li>
  <li>
    <b>Finally getting a grasp on Dependency Injection</b>
    <p>
      asdf
    </p>
  </li>
  <li>
    <b>Developing the project to scale</b>
    <p>
      asdf
    </p>
  </li>
</ul>

<h3>Helpful Resources:</h3>




