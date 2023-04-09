---------------------------------------English

Develop a technical task. Show the decomposition of the task, where some of the tasks should be implemented using generative patterns:
- Strategy. 
- Observer. 
- Command.  

Terms of reference.
To develop a report generation system that can generate reports with different data sources, filters and visualizations in various formats, including CSV, PDF and HTML.

1.Design the architecture of the report generation system, including various components such as data sources, filters, visualizations, and export formats.

2.Develop different strategies for exporting data in CSV, PDF and HTML formats. Implement the IExportStrategy interface and create classes for each export strategy, such as CsvExportStrategy, PdfExportStrategy, and HtmlExportStrategy.

3.Develop different strategies for applying filters to data, such as a date range filter and a category filter. Implement the IFilterStrategy interface and create classes for each filtering strategy, such as DateRangeFilterStrategy and CategoryFilterStrategy.

4.Develop various data visualization strategies, such as bar charts and line graphs. Implement the IVisualizationStrategy interface and create classes for each visualization strategy, for example, BarChartVisualizationStrategy and LineChartVisualizationStrategy.

5.Create a report generator class that will use different strategies to generate reports based on the specified data source, filters, and visualization strategy. Implement the IReportCommand interface and create a GenerateReportCommand class that will perform the necessary steps to generate a report, including applying filters, visualizing the data, and exporting the report in the specified format.

Requirements:
- The report generator must be implemented in C#.
- The generator should be developed using the Strategy, Command, and Observer templates.
- The tool should allow the user to apply different types of filters to the data, such as date range filters and category filters.
- The tool should allow the user to visualize the data in a variety of ways, such as bar charts and line graphs.
- The tool should allow the user to export data to various formats such as CSV and Excel. 
Deliverables:
- C# code that implements the report generator using Strategy, Command, and Observer.
- Unit tests that verify the functionality of the report generator.


This code presents a system for creating DataTable reports using various export strategies, filtering strategies, and visualization strategies. It uses the Command, Strategy, and Observer design patterns.

The system defines interfaces for different types of strategies: IExportStrategy for exporting data, IFilterStrategy for applying filters, and IVisualizationStrategy for visualizing data. It also defines the IDataObserver interface for observing data changes.

Specific implementations of these interfaces are also provided, such as CsvExportStrategy and DateRangeFilterStrategy.

The GenerateReportCommand class is defined using the Command template, which encapsulates a set of actions to be performed on the data. For this purpose, a DataTable is used, as well as instances of various strategic interfaces and a data observer. The Execute method of this class performs the actual filtering, visualization, and export operations on the data using the provided strategies.

The ReportGenerator class takes a DataTable and a data observer in its constructor. Its GenerateReport method takes instances of various strategy interfaces and creates a GenerateReportCommand object with the provided parameters, which it then executes.

The code creates instances of various strategies and passes them to the ReportGenerator to generate a report. The CsvExportStrategy is used to export data to CSV format, the DateRangeFilterStrategy is used to apply a date range filter to the data, and the BarChartVisualizationStrategy is used to display the data in a bar chart.


---------------------------------------Українська

Розробити технічне завдання. Показати декомпонування завдання, де частина завдань має бути реалізована з використанням породжуючих патернів:
-	Стратегія (Strategy). 
-	Спостерігач (Observer). 
-	Команда (Command).  

Технічне завдання
Розробити систему генерації звітів, яка може створювати звіти з різними джерелами даних, фільтрами та візуалізаціями у різних форматах, включаючи CSV, PDF та HTML.

1.Розробити архітектуру системи генерації звітів, включаючи різні компоненти, такі як джерела даних, фільтри, візуалізації та формати експорту.

2.Розробити різні стратегії для експорту даних у форматах CSV, PDF та HTML. Реалізувати інтерфейс IExportStrategy та створити класи для кожної стратегії експорту, такі як CsvExportStrategy, PdfExportStrategy та HtmlExportStrategy.

3.Розробіть різні стратегії застосування фільтрів до даних, наприклад, фільтр діапазону дат і фільтр категорій. Реалізуйте інтерфейс IFilterStrategy і створіть класи для кожної стратегії фільтрації, наприклад, DateRangeFilterStrategy і CategoryFilterStrategy.

4.Розробіть різні стратегії візуалізації даних, наприклад, гістограми та лінійні діаграми. Реалізуйте інтерфейс IVisualizationStrategy і створіть класи для кожної стратегії візуалізації, наприклад, BarChartVisualizationStrategy і LineChartVisualizationStrategy.

5.Створіть клас генератора звітів, який використовуватиме різні стратегії для створення звітів на основі вказаного джерела даних, фільтрів і стратегії візуалізації. Реалізуйте інтерфейс IReportCommand і створіть клас GenerateReportCommand, який буде виконувати необхідні кроки для створення звіту, включаючи застосування фільтрів, візуалізацію даних і експорт звіту у вказаному форматі.
Вимоги:
•	Генератор звітів повинен бути реалізований на C#.
•	Генератор має бути розроблений за допомогою шаблонів Strategy, Command і Observer.
•	Інструмент має дозволяти користувачеві застосовувати різні типи фільтрів до даних, наприклад фільтри діапазону дат і фільтри категорій.
•	Інструмент має дозволяти користувачеві візуалізувати дані різними способами, наприклад гістограмами та лінійчатими діаграмами.
•	Інструмент повинен дозволяти користувачеві експортувати дані в різні формати, такі як CSV і Excel. 
Результати роботи:
•	Код C#, який реалізує генератор звітів за допомогою Strategy, Command і Observer.
•	Модульні тести, які перевіряють функціональність генератора звітів.


Цей код представляє систему для створення звітів DataTable з використанням різних стратегій експорту, стратегій фільтрації та стратегій візуалізації. Він використовує шаблони проектування Command, Strategy і Observer.

Система визначає інтерфейси для різних типів стратегій: IExportStrategy для експорту даних, IFilterStrategy для застосування фільтрів і IVisualizationStrategy для візуалізації даних. Він також визначає інтерфейс IDataObserver для спостереження за змінами даних.

Також надаються конкретні реалізації цих інтерфейсів, наприклад CsvExportStrategy і DateRangeFilterStrategy.

Клас GenerateReportCommand визначається за допомогою шаблону Command, який інкапсулює набір дій, які потрібно виконати над даними. Для цього використовується DataTable, а також екземпляри різних стратегічних інтерфейсів і спостерігач даних. Метод Execute цього класу виконує фактичні операції фільтрації, візуалізації та експорту даних за допомогою наданих стратегій.

Клас ReportGenerator приймає DataTable і спостерігач даних у своєму конструкторі. Його метод GenerateReport бере екземпляри різних інтерфейсів стратегії та створює об’єкт GenerateReportCommand із наданими параметрами, які потім виконує.

Код створює екземпляри різних стратегій і передає їх у ReportGenerator для створення звіту. CsvExportStrategy використовується для експорту даних у формат CSV, DateRangeFilterStrategy використовується для застосування фільтра діапазону дат до даних, а BarChartVisualizationStrategy використовується для відображення даних у вигляді гістограми.
