
# CQRS
- CQRS stands for Command and Query Responsibility Segregation, where Commands represents the writes and Queries represents the reads
- A pattern that separates read and update operations for a data store. Implementing CQRS in your application can maximize its performance, scalability, and security. 
- The flexibility created by migrating to CQRS allows a system to better evolve over time and prevents update commands from causing merge conflicts at the domain level.



			Command Side ------------------ Qurey Side
				Create ---------------------- Read
				Update
				Delete
	***On the command side, you will have Create, Update and Delete, and on the query side, you will have all the reads***.



 ## Why do we need CQRS?
 - Data is often more frequently queried than altered, or vise versa.
 - It allows you to scale the command and query APIs independently from each other.
 - It also allows you to optimise your reads and write data schemas,
	 - where the schema of the read side can be optimised for queries, 
	 - while the schema on the write or command side, can be optimized for writes or updates.
- For example: If you store a materialized view of your data in the read database, 
	- your query API won't have to do any complex joins between tables or collections.
- It allows you to separate concerns.
	- Generally, you will find that complex business logic is applied on the write model,
		- while the read model is usually quite  simple.
- Finally, 
	- you can improve your data security by ensuring that only the relevant command API,
		- is allowed to perform write operations on the given write database or event store.



# EVENT SOURCING 

- Event Sourcing is a software design pattern that is commonly combined with secrets.
- Defines an approach where all the changes that are made to an object or entity are stored as a sequence of immutable events to an event store as opposed to just storing the  current state.

### Benefits of Event Sourcing
- The event store basically contains a complete auditable log.
	- In other words, all the state changes that were applied to the object or entity, 
		- instead of just storing the latest or current state, as is common in traditional applications.
- The state of an object, 
	- usually the aggregate, can be recreated by replaying the event store.
- It improves write performance, since all events are simply appended to the event store.
	- In other words, 
	- we never do any update or delete operations or the event store.
- In case of failure, 
	- the event store can be used to restore the read database.



## Architecture

![[Pasted image 20240412105420.png]]

## APACHE KAFKA

- Apache Kafka is an open source event streaming platform that enables the creation of real time event driven application.
- Kafka was developed by linkedIn in 2011 as a high-throughput message broker for its own internal use.
	- It was then open-sourced and donated to the Apache Foundation.
- Today, Kafka has evolved into the most widely-used streaming platform, without any noticeable performance lag.



## MESSAGES

1. Command
2. Event
3. Queries

#### 1. Command
- A Command, is a combination of expressed intent. In other words it describes an action that you want to be performed.
- It also contains the information that is required to undertake the desired action
- Commands are always named with a verb in the imperative mood.
For Example:
- NewPostCommand
- LikePostCommand
- AddCommentCommand


## EVENT

What is an Event?
- Events are objects that describe something that has occurred in the application.
	- A typical source of events is the aggregate.
- When something important happens in the aggregate, it will raise an event.
- Events are named with a past-particle verb.
For Example:
- PostCreatedEvent,
- PostLlikedEvent,
- CommentAddedEvent


## MEDIATOR PATTERN

- Behavioral Design Pattern
- Promotes loose coupling by preventing objects from referring to each other explicitly
- Simplifies the communication between objects by introducing a single object known as the "Mediator" that manages the distribution of messages among other objects


![[Mediator+Pattern.drawio.png]]

![[Mediator+-+Command+Dispatching.drawio(1).png]]


