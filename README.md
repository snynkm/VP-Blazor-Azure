# Pizza Ordering Application (Demo)

<h3>Demo Link: 🔥🍕<a href="https://vennatospizza.azurewebsites.net/">Visit My Project Demo at Vennato's Pizza Website</a>🍕🔥 </h3>

Application Name: Vennato's Pizza

<h2 id="backtotop">Table of Contents:</h2>
<ul>
  <li><a href="#summary">Summary</a></li>
  <li><a href="#background">Background</a></li>
  <li><a href="#technology">Technology</a></li>
  <li><a href="#features">Features</a></li>
  <li><a href="#eurekamoments">Eureka Moments</a></li>
  <li><a href="#missedopportunities">Missed Opportunities</a></li>
  <li><a href="#helpfulresources">Helpful Resources</a></li>
  <li><a href="#imagereferencesheet">Image Reference Sheet</a></li>
  <li><a href="#contactinfo">Contact Info</a></li>
</ul>

<h2 id="summary">Summary:</h2>
<p>This is my first full-stack application project which is a demo Pizza Ordering Application. I wanted to create a website similar to company websites like Domino's and Little Caesars, where the user can check out menu items and order online. The Feature Section explains more of the application functions. </p>

<h2 id="technology">Technology:</h2>
<p>Below are main technologies used for development:</p>
<table>
  <tr>
    <th><b>  Technologies:</b></th>
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
</table>



<h2 id="background">Background:</h2>

<p>
  Regarding the project's theme, I wanted to keep it simple - develop a Pizza App. I chose this idea for of a couple of reason. Firstly, I didn't know what else to think of. As a new developer, I didnt have the experience to come up with a sophisticated idea that solves a specific business problem. The latter reason more importantly, I felt that going with a Pizza App is something that many people are familiar with. My goal wasn't to oversell on the project idea, but to instead focus within the application and make sure it includes certain features and enhancements that really draw out a smooth user experience (hopefully). 
</p>

<p>
  In summary, the project was definitely a grind but also something I found to be very rewarding. In terms of technicality, the project itself is nowhere near perfect. There were several things I felt could have been improved upon but due to time constraints wasn't able to restructure. That being said, I still learned a lot and had tons of fun developing it. To name a few, my favorite parts were coming up with the products and pricing, designing the UX/UI, and implementing creative solutions to work around issues.
</p>
<a href="#backtotop">Back to Top</a>
<h2 id="features">Features:</h2>
<ol>
<li>
  <h3>Product Catalog</h3>
</li>
  <img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/87fcd45a-b61d-4b75-840b-bef52fb4b2de" alt="Menu" height="300">
  <img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/85377337-90d7-4290-9a36-95e5fa7b4e2e" alt="AddItem component" height="300">
  <ul> 
    <li>Retrieves full catalog from database and displays it on the menu</li>
    <li>Includes overlay component where useres can select items. Includes dynamic two-way binded fields that immediately updates values.</li>
  </ul>
<li>
  <h3>Shopping Cart</h3>
  <img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/37f6ec42-351c-426c-980b-7f49edfbf239" alt="Menu" height="300">
  <ul><li>Allows quantity update and item removal and displays dynamic subtotal.</li></ul>
</li>
<li>
  <h3>Dynamic Checkout Process & Order Submission</h3>
    <img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/9e21799e-285a-421a-be26-3dd28991f63b" alt="Checkout" height="300">
    <img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/046cdf90-a914-41ac-90b8-97bf27fb8ba2" alt="Data Validations" height="300">
    <img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/6c042ed4-a274-4c4b-b354-419e9b766220" alt="Checkout Flow Indicator" height="300">
    <ul>
    <li>Includes dynamic checkout flow that prefills info submitted prior to checkout.</li>
    <li>Runs client-side data validations to check for input errors.</li>
    <li>Includes a timeline that indicates checkout process step.</li>
    </ul>
</li>
<li>
  <h3>Business Analysis/Reporting</h3>
      <ul>
        <li>Scalable and queryable database design for back-end use. Once transactional data has been stored into the database, it can be easily queried and maintained.</li>
      </ul>
      <p>
        Below is an example of how data from the Order table is stored:
      </p>  
      </p>
    <table background-color="red" width="40">
      <tr><td><p>1. Items are added from the menu and order created:</p></td></tr>
      <tr><td><p><img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/73a230d0-917e-435e-bf94-5a72ced51c70" alt="Summary" width="400"></p></td></tr>
      <tr><td><p>2. Order data is inserted into respective tables:</p></td></tr>
      <tr><td><p><img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/0489fd63-221d-41e8-ae0c-fc843dbf5673" alt="Normalized Data" width="600"></p></tr></td>
      <tr><td><p>3. Map catalog info from Orders:</p></td></tr>  
      <tr><td><p><img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/855395e0-3f37-48ec-bf01-c66414d3cfab" alt="Full MenuItem Lookup" width="500"></p></td></tr>
      <tr><td><p>With this database structure, and the ability to link these tables, from there you can perform more complex queries to solve business questions such as:</p>
        <p>(1) <i>Most popular item during X-month?</i></p>
        <p>(2) <i>States with more carryout vs delivery during X-month(s)?</i>i></p>
        <p>(3) <i>Average item count per order during X-months(s)?</i></p>
        <p>Check out the full diagram on how I linked the tables:</p>
        <tr><td><p><img src="https://github.com/snynkm/VP-Blazor-Azure/assets/114448769/f99a3934-79ba-41b0-9a9a-65ea16664860" alt="Diagram" width="800"></p></td></tr>
      </td></tr>
    </table>
</li>
</ol>

<h2 id="eurekamoments">Eureka Moments:</h2> 
<ul>
  <li>
    <b>Understanding Component Life Cycles</b>
    <p>I learned this concept when trying to display object properties in different components (such as OrderItem, Customer, Branch, etc.). I was first attempting to put them all as component properties and have them inherited. However, during testing I kept running into issues of objects being set to null which kept crashing my app. I didn't know why this was happening until I found out that component properties are essentially tied to their respective life cycles. This means they are temporary and reset once the cycle finishes which happens when you navigate away from the component (if I understand correctly). Around the same time, I also found out about Share State and what it does. So together with those two concepts in mind, I had to ask myself, <i> which object should I initialize directly in the component vs in the Shared State? </i> I basically boiled it down into one thing, <i>does the initalized object need to change during the app session (two way binded) or does it not need to change (one way bind)? </i> Object properties such as a Customer's First and Last name need to change based on the user. Inversely, objects such as State doesn't have to change because a State name (i.e. Massachusetts) typically doesn't change. For all two-way bound data, I initialized in the Shared State and for single bind, I kept locally in the component.</p>
  </li>
  <li>
    <b>Learning about Shared State</b>
    <p>
      At this point of the project, I had already configured both the Product Catalog and the ShoppingCart component, and was now ready to start with the checkout flow. I hit a major road block and wasn't sure how to proceed with a dynamic checkout flow that was contingent on multiple pieces of data, spread across various components. Luckily around the same time, I started to use chat GPT for the project and was able to ask it questions on how to proceed. It basically gave me two options, I could use EventCallback with each component or use a Shared State class. I ended up going with the Shared State because it made more sense to do so. Plus, I had used EventCallbacks in two of my components previously and wasn't really a fan of how much code was required to communicate a single piece of data between two components. Implementing a Shared State was crucial to my application and it allowed me to better understand how data can be changed and shared across different components. The only caveat to using Shared State is that it requires a lot of overhead so it's important distinquish what items absolutely need to be in the Shared State.
    </p>
  </li>
  <li>
    <b>Finding out what a DTO is midway through the project</b>
    <p>
      While working on the checkout process, I needed to find a way to package the session data to be inserted back into the database. After watching some videos, I stumble across the principle of Data Transfer Objects (DTOs). This was a huge concept that I think would've made the project easier if I had learned it at the beginning. It's basically a custom class model located above the data access layer, designed to group only relevant data that users need to see. With this concept, I was presented a fork in the road, <i>should I restructure the application to use DTOs, or should I proceed with the current setup?</i> Although the current setup was working fine, I ultimately decided to restructure the application. This was one of the biggest changes I made on the project. And since this change involved restructuring every project (database, class library and webapp), I ended up creating some sort of unit test first, where I made a simple version of the current solution, involving only the relevant classes, models, and components that were tied to this change. I tested the solution to make sure it works and then slowly began restructuring my current solution based on the test solution. In restrospect, I think this change was necessary. It made some of my components cleaner and easier to read/write. I was also able to clean up my database structure and also got good experience being able to spin up a new solution a lot quicker. 
    </p>
    
  </li>
  <li>
    <b>Finally getting a grasp on Dependency Injection</b>
    <p>
      This was a concept that I had actually learned before starting the project. But for some reason, the concept was still very difficult for me to conceptualize. I didn't quite understand it until way later in the project. Thankfully, I followed one of <a href="https://www.youtube.com/watch?v=dwMFg6uxQ0I&t=978s">Tim Corey's Videos</a> on implementing Dependency Injection early on to get me started with the data access layer. I didn't really understand it, just used the code to move along. It wasn't until I started using my own business logic where I began to understand how it works. I had to implement my own CartItemService to initialize objects, which simultaneously helped me better understand (1) how generics work, (2) registering services such as AddTransient(), AddScoped(), and AddSingleton(), and (3) abstraction. 
    </p>
  </li>
  <li>
    <b>Developing the project to scale</b>
    <p>
      It wasn't a particular issue that led me to understand how to scale, rather it was simply going through the process of recursively expanding the application. I realized that there are many different parts of the app that can be easily expanded upon, ie. setting the tax rate for the Order to be based on the StateId rather than a fixed amount. It's easy to do this if the database is set up properly with linking IDs. I think the main factor of scalability stems from good database structure. If you can simply add a new table into a normalized schema, it will help scale the application and minimize the amount of work needed to expand certain parts. Based on my personal database, I think there are some parts that could be better normalized and some parts that may have been overkill. But the important thing is to understand when it's appropriate to design something that scales vs prioritizing deliverables.
    </p>
  </li>
</ul>

<h2 id="missedopportunities">Missed Opportunities:</h2>
There were many features I wanted to include on the application that simply fell out of scope due to time constraints: 
<p><ul>
  <li><b>Payment Transaction Service</b> - I would have liked to add some sort of payment processing microservice in with the application. But after researching, it seems that implementing a transaction service would open up a whole 'nother can of worms. At larger companies, these payment processes need to be audited in some fashion which would require detailed security configurations. I think I could figure out how to implement this but it would require a lot of bandwidth and time.  </li>
  <li><b>Email Notification Service</b> - Another service that fell out of scope due to time. Although, I did do research and found that I could probably add the service using Azure Functions and an email service such as Amazon SES or SendGrid. This might be something I can include on a future project.</li>
  <li><b>Log In Service</b> - Like the payment transaction service, it seems like this would have required some additional microservice with detailed security enhancements. I wasn't able to produce this but at the very least, I did configure the application in a way that I felt can easily scale if deciding to add this in later. I'm not sure if this is orthodox practice, but I ended up duplicating the Customer table (now a Parent Model/no table) into the User and Guest tables (inherited Models/populated tables) with the ability to join either table on the Order table using a common attribute (CustomerId - which is technically not an FK but serves similar functionality). That way, if I wanted to add a login service, the system could do a SELECT on just the User table. It wouldn't have to filter through all the guest information and only check returning customers' from the User table.</li>
</ul>
</p>


<h2 id="helpfulresources">Helpful Resources:</h2>
<p>Tim Corey's Youtube channel helped me tremendously with a lot of the initial configurations for the project. I also visited various other channels on Youtube to help me understand broader topics. My <a href="https://github.com/snynkm/snynkm">Landing Page's</a> Self-Education section elaborates more on the resources I've used to help me get started as a .NET developer.</p>

<h2 id="imagereferencesheet">Image Reference Sheet:</h2>
<p>
  Image Url Reference Sheet: (https://github.com/snynkm/VP-Blazor-Azure/files/12285865/VP.Image.Url.Reference.Sheet.xlsx)
  </p>
  
<h2 id="contactinfo">Contact Info:</h2>
<p>
  Check out my <a href="https://github.com/snynkm/snynkm">Landing Page</a> to learn more about my goals and other projects!
</p>

📫 Email: **snk.bus@gmail.com**
<h3 align="left">Connect with me:</h3>
<p align="left">
<a href="https://linkedin.com/in/https://www.linkedin.com/in/sean-kim-222576120/" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="https://www.linkedin.com/in/sean-kim-222576120/" height="30" width="40" /></a>
</p>

