namespace DoIGetItTheScrumGuide.Model
{
    using System.Collections.Generic;
    
    public class Document
    {
        public List<Section> Sections { get; private set; }

        public List<Question> Questions { get; private set; }

        public Document()
        {
            InitializeSections();
            InitializeQuestions();
        }

        private void InitializeSections()
        {
            Sections = new List<Section>
            {
                new Section
                {
                    Id = 1,
                    Heading = "Purpose of the Scrum Guide",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "Scrum is a framework for developing and sustaining complex products. This Guide contains the definition of Scrum. This definition consists of Scrum’s roles, events, artifacts, and the rules that bind them together. Ken Schwaber and Jeff Sutherland developed Scrum; the Scrum Guide is written and provided by them. Together, they stand behind the Scrum Guide.")
                    }
                },
                new Section
                {
                    Id = 2,
                    Heading = "Definition of Scrum",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "Scrum: A framework within which people can address complex adaptive problems, while productively and creatively delivering products of the highest possible value."),
                        new Paragraph(2, "Scrum is: Lightweight, Simple to understand, Difficult to master."),
                        new Paragraph(3, "Scrum is a process framework that has been used to manage complex product development since the early 1990s. Scrum is not a process or a technique for building products; rather, it is a framework within which you can employ various processes and techniques. Scrum makes clear the relative efficacy of your product management and development practices so that you can improve."),
                        new Paragraph(4, "The Scrum framework consists of Scrum Teams and their associated roles, events, artifacts, and rules. Each component within the framework serves a specific purpose and is essential to Scrum’s success and usage."),
                        new Paragraph(5, "The rules of Scrum bind together the events, roles, and artifacts, governing the relationships and interaction between them. The rules of Scrum are described throughout the body of this document."),
                        new Paragraph(6, "Specific tactics for using the Scrum framework vary and are described elsewhere.")
                    }
                },
                new Section
                {
                    Id = 3,
                    Heading = "Scrum Theory",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "Scrum is founded on empirical process control theory, or empiricism. Empiricism asserts that knowledge comes from experience and making decisions based on what is known. Scrum employs an iterative, incremental approach to optimize predictability and control risk." ),
                        new Paragraph(2, "Three pillars uphold every implementation of empirical process control: transparency, inspection, and adaptation." ),
                        new Paragraph(3, "Transparency: Significant aspects of the process must be visible to those responsible for the outcome. Transparency requires those aspects be defined by a common standard so observers share a common understanding of what is being seen."),
                        new Paragraph(4, "For example: A common language referring to the process must be shared by all participants; and, Those performing the work and those accepting the work product must share a common definition of 'Done'"),
                        new Paragraph(5, "Inspection: Scrum users must frequently inspect Scrum artifacts and progress toward a Sprint Goal to detect undesirable variances. Their inspection should not be so frequent that inspection gets in the way of the work. Inspections are most beneficial when diligently performed by skilled inspectors at the point of work."),
                        new Paragraph(6, "Adaptation: If an inspector determines that one or more aspects of a process deviate outside acceptable limits, and that the resulting product will be unacceptable, the process or the material being processed must be adjusted. An adjustment must be made as soon as possible to minimize further deviation."),
                        new Paragraph(7, "Scrum prescribes four formal events for inspection and adaptation, as described in the Scrum Events section of this document: Sprint Planning, Daily Scrum, Sprint Review, Sprint Retrospective")
                    }
                },
                new Section
                {
                    Id = 4,
                    Heading = "The Scrum Team",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Scrum Team consists of a Product Owner, the Development Team, and a Scrum Master. Scrum Teams are self-organizing and cross-functional. Self-organizing teams choose how best to accomplish their work, rather than being directed by others outside the team. Cross-functional teams have all competencies needed to accomplish the work without depending on others not part of the team. The team model in Scrum is designed to optimize flexibility, creativity, and productivity."),
                        new Paragraph(2, "Scrum Teams deliver products iteratively and incrementally, maximizing opportunities for feedback. Incremental deliveries of “Done” product ensure a potentially useful version of working product is always available.")
                    }
                },
                new Section
                {
                    Id = 5,
                    Heading = "The Product Owner",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Product Owner is responsible for maximizing the value of the product and the work of the Development Team. How this is done may vary widely across organizations, Scrum Teams, and individuals."),
                        new Paragraph(2, "The Product Owner is the sole person responsible for managing the Product Backlog. Product Backlog management includes: Clearly expressing Product Backlog items; Ordering the items in the Product Backlog to best achieve goals and missions; Optimizing the value of the work the Development Team performs; Ensuring that the Product Backlog is visible, transparent, and clear to all, and shows what the Scrum Team will work on next; and, Ensuring the Development Team understands items in the Product Backlog to the level needed."),
                        new Paragraph(3, "The Product Owner may do the above work, or have the Development Team do it. However, the Product Owner remains accountable."),
                        new Paragraph(4, "The Product Owner is one person, not a committee. The Product Owner may represent the desires of a committee in the Product Backlog, but those wanting to change a Product Backlog item’s priority must address the Product Owner."),
                        new Paragraph(5, "For the Product Owner to succeed, the entire organization must respect his or her decisions. The Product Owner’s decisions are visible in the content and ordering of the Product Backlog. No one is allowed to tell the Development Team to work from a different set of requirements, and the Development Team isn’t allowed to act on what anyone else says.")
                    }
                },
                new Section
                {
                    Id = 6,
                    Heading = "The Development Team",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Development Team consists of professionals who do the work of delivering a potentially releasable Increment of “Done” product at the end of each Sprint. Only members of the Development Team create the Increment."),
                        new Paragraph(2, "Development Teams are structured and empowered by the organization to organize and manage their own work. The resulting synergy optimizes the Development Team’s overall efficiency and effectiveness."),
                        new Paragraph(3, "Development Teams have the following characteristics: They are self-organizing. No one (not even the Scrum Master) tells the Development Team how to turn Product Backlog into Increments of potentially releasable functionality; Development Teams are cross-functional, with all of the skills as a team necessary to create a product Increment; Scrum recognizes no titles for Development Team members other than Developer, regardless of the work being performed by the person; there are no exceptions to this rule; Scrum recognizes no sub-teams in the Development Team, regardless of particular domains that need to be addressed like testing or business analysis; there are no exceptions to this rule; and, Individual Development Team members may have specialized skills and areas of focus, but accountability belongs to the Development Team as a whole."),
                        new Paragraph(4, "Development Team Size: Optimal Development Team size is small enough to remain nimble and large enough to complete significant work within a Sprint. Fewer than three Development Team members decrease interaction and results in smaller productivity gains. Smaller Development Teams may encounter skill constraints during the Sprint, causing the Development Team to be unable to deliver a potentially releasable Increment. Having more than nine members requires too much coordination. Large Development Teams generate too much complexity for an empirical process to manage. The Product Owner and Scrum Master roles are not included in this count unless they are also executing the work of the Sprint Backlog.")
                    }
                },
                new Section
                {
                    Id = 7,
                    Heading = "The Scrum Master",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Scrum Master is responsible for ensuring Scrum is understood and enacted. Scrum Masters do this by ensuring that the Scrum Team adheres to Scrum theory, practices, and rules."),
                        new Paragraph(2, "The Scrum Master is a servant-leader for the Scrum Team. The Scrum Master helps those outside the Scrum Team understand which of their interactions with the Scrum Team are helpful and which aren’t. The Scrum Master helps everyone change these interactions to maximize the value created by the Scrum Team.")
                    }
                },
                new Section
                {
                    Id = 8,
                    Heading = "Scrum Master Service to the Product Owner",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Scrum Master serves the Product Owner in several ways, including: Finding techniques for effective Product Backlog management; Helping the Scrum Team understand the need for clear and concise Product Backlog items; Understanding product planning in an empirical environment; Ensuring the Product Owner knows how to arrange the Product Backlog to maximize value; Understanding and practicing agility; and, Facilitating Scrum events as requested or needed."),
                    }
                },
                new Section
                {
                    Id = 9,
                    Heading = "Scrum Master Service to the Development Team",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Scrum Master serves the Development Team in several ways, including: Coaching the Development Team in self-organization and cross-functionality; Helping the Development Team to create high-value products; Removing impediments to the Development Team’s progress; Facilitating Scrum events as requested or needed; and, Coaching the Development Team in organizational environments in which Scrum is not yet fully adopted and understood."),
                    }
                },
                new Section
                {
                    Id = 10,
                    Heading = "Scrum Master Service to the Organization",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Scrum Master serves the organization in several ways, including: Leading and coaching the organization in its Scrum adoption; Planning Scrum implementations within the organization; Helping employees and stakeholders understand and enact Scrum and empirical product development; Causing change that increases the productivity of the Scrum Team; and, Working with other Scrum Masters to increase the effectiveness of the application of Scrum in the organization."),
                    }
                },
                new Section
                {
                    Id = 11,
                    Heading = "Scrum Events",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "Prescribed events are used in Scrum to create regularity and to minimize the need for meetings not defined in Scrum. All events are time-boxed events, such that every event has a maximum duration. Once a Sprint begins, its duration is fixed and cannot be shortened or lengthened. The remaining events may end whenever the purpose of the event is achieved, ensuring an appropriate amount of time is spent without allowing waste in the process."),
                        new Paragraph(2, "Other than the Sprint itself, which is a container for all other events, each event in Scrum is a formal opportunity to inspect and adapt something. These events are specifically designed to enable critical transparency and inspection. Failure to include any of these events results in reduced transparency and is a lost opportunity to inspect and adapt."),
                    }
                },
                new Section
                {
                    Id = 12,
                    Heading = "The Sprint",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The heart of Scrum is a Sprint, a time-box of one month or less during which a “Done”, useable, and potentially releasable product Increment is created. Sprints best have consistent durations throughout a development effort. A new Sprint starts immediately after the conclusion of the previous Sprint."),
                        new Paragraph(2, "Sprints contain and consist of the Sprint Planning, Daily Scrums, the development work, the Sprint Review, and the Sprint Retrospective."),
                        new Paragraph(3, "During the Sprint: No changes are made that would endanger the Sprint Goal; Quality goals do not decrease; and, Scope may be clarified and re-negotiated between the Product Owner and Development Team as more is learned."),
                        new Paragraph(4, "Each Sprint may be considered a project with no more than a one-month horizon. Like projects, Sprints are used to accomplish something. Each Sprint has a definition of what is to be built, a design and flexible plan that will guide building it, the work, and the resultant product."),
                        new Paragraph(5, "Sprints are limited to one calendar month. When a Sprint’s horizon is too long the definition of what is being built may change, complexity may rise, and risk may increase. Sprints enable predictability by ensuring inspection and adaptation of progress toward a Sprint Goal at least every calendar month. Sprints also limit risk to one calendar month of cost."),
                    }
                },
                new Section
                {
                    Id = 13,
                    Heading = "Cancelling a Sprint",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "A Sprint can be cancelled before the Sprint time-box is over. Only the Product Owner has the authority to cancel the Sprint, although he or she may do so under influence from the stakeholders, the Development Team, or the Scrum Master."),
                        new Paragraph(2, "A Sprint would be cancelled if the Sprint Goal becomes obsolete. This might occur if the company changes direction or if market or technology conditions change. In general, a Sprint should be cancelled if it no longer makes sense given the circumstances. But, due to the short duration of Sprints, cancellation rarely makes sense."),
                        new Paragraph(3, "When a Sprint is cancelled, any completed and “Done” Product Backlog items are reviewed. If part of the work is potentially releasable, the Product Owner typically accepts it. All incomplete Product Backlog Items are re-estimated and put back on the Product Backlog. The work done on them depreciates quickly and must be frequently re-estimated."),
                        new Paragraph(4, "Sprint cancellations consume resources, since everyone has to regroup in another Sprint Planning to start another Sprint. Sprint cancellations are often traumatic to the Scrum Team, and are very uncommon."),
                    }
                },
                new Section
                {
                    Id = 14,
                    Heading = "Sprint Planning",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The work to be performed in the Sprint is planned at the Sprint Planning. This plan is created by the collaborative work of the entire Scrum Team."),
                        new Paragraph(2, "Sprint Planning is time-boxed to a maximum of eight hours for a one-month Sprint. For shorter Sprints, the event is usually shorter. The Scrum Master ensures that the event takes place and that attendants understand its purpose. The Scrum Master teaches the Scrum Team to keep it within the time-box."),
                        new Paragraph(3, "Sprint Planning answers the following: What can be delivered in the Increment resulting from the upcoming Sprint? How will the work needed to deliver the Increment be achieved?"),
                        new Paragraph(4, "Topic One: What can be done this Sprint? The Development Team works to forecast the functionality that will be developed during the Sprint. The Product Owner discusses the objective that the Sprint should achieve and the Product Backlog items that, if completed in the Sprint, would achieve the Sprint Goal. The entire Scrum Team collaborates on understanding the work of the Sprint."),
                        new Paragraph(5, "The input to this meeting is the Product Backlog, the latest product Increment, projected capacity of the Development Team during the Sprint, and past performance of the Development Team. The number of items selected from the Product Backlog for the Sprint is solely up to the Development Team. Only the Development Team can assess what it can accomplish over the upcoming Sprint."),
                        new Paragraph(6, "After the Development Team forecasts the Product Backlog items it will deliver in the Sprint, the Scrum Team crafts a Sprint Goal. The Sprint Goal is an objective that will be met within the Sprint through the implementation of the Product Backlog, and it provides guidance to the Development Team on why it is building the Increment."),
                        new Paragraph(7, "Topic Two: how will the chosen work get done? Having set the Sprint Goal and selected the Product Backlog items for the Sprint, the Development Team decides how it will build this functionality into a “Done” product Increment during the Sprint. The Product Backlog items selected for this Sprint plus the plan for delivering them is called the Sprint Backlog."),
                        new Paragraph(8, "The Development Team usually starts by designing the system and the work needed to convert the Product Backlog into a working product Increment. Work may be of varying size, or estimated effort. However, enough work is planned during Sprint Planning for the Development Team to forecast what it believes it can do in the upcoming Sprint. Work planned for the first days of the Sprint by the Development Team is decomposed by the end of this meeting, often to units of one day or less. The Development Team self-organizes to undertake the work in the Sprint Backlog, both during Sprint Planning and as needed throughout the Sprint."),
                        new Paragraph(9, "The Product Owner can help to clarify the selected Product Backlog items and make trade-offs. If the Development Team determines it has too much or too little work, it may renegotiate the selected Product Backlog items with the Product Owner. The Development Team may also invite other people to attend in order to provide technical or domain advice."),
                        new Paragraph(10, "By the end of the Sprint Planning, the Development Team should be able to explain to the Product Owner and Scrum Master how it intends to work as a self-organizing team to accomplish the Sprint Goal and create the anticipated Increment."),
                    }
                },
                new Section
                {
                    Id = 15,
                    Heading = "Sprint Goal",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Sprint Goal is an objective set for the Sprint that can be met through the implementation of Product Backlog. It provides guidance to the Development Team on why it is building the Increment. It is created during the Sprint Planning meeting. The Sprint Goal gives the Development Team some flexibility regarding the functionality implemented within the Sprint. The selected Product Backlog items deliver one coherent function, which can be the Sprint Goal. The Sprint Goal can be any other coherence that causes the Development Team to work together rather than on separate initiatives."),
                        new Paragraph(2, "As the Development Team works, it keeps the Sprint Goal in mind. In order to satisfy the Sprint Goal, it implements the functionality and technology. If the work turns out to be different than the Development Team expected, they collaborate with the Product Owner to negotiate the scope of Sprint Backlog within the Sprint."),
                    }
                },
                new Section
                {
                    Id = 16,
                    Heading = "Daily Scrum",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Daily Scrum is a 15-minute time-boxed event for the Development Team to synchronize activities and create a plan for the next 24 hours. This is done by inspecting the work since the last Daily Scrum and forecasting the work that could be done before the next one. The Daily Scrum is held at the same time and place each day to reduce complexity. "),
                        new Paragraph(2, "During the meeting, the Development Team members explain: What did I do yesterday that helped the Development Team meet the Sprint Goal? What will I do today to help the Development Team meet the Sprint Goal? Do I see any impediment that prevents me or the Development Team from meeting the Sprint Goal?"),
                        new Paragraph(3, "The Development Team uses the Daily Scrum to inspect progress toward the Sprint Goal and to inspect how progress is trending toward completing the work in the Sprint Backlog. The Daily Scrum optimizes the probability that the Development Team will meet the Sprint Goal. Every day, the Development Team should understand how it intends to work together as a self-organizing team to accomplish the Sprint Goal and create the anticipated Increment by the end of the Sprint. The Development Team or team members often meet immediately after the Daily Scrum for detailed discussions, or to adapt, or replan, the rest of the Sprint’s work."),
                        new Paragraph(4, "The Scrum Master ensures that the Development Team has the meeting, but the Development Team is responsible for conducting the Daily Scrum. The Scrum Master teaches the Development Team to keep the Daily Scrum within the 15-minute time-box."),
                        new Paragraph(5, "The Scrum Master enforces the rule that only Development Team members participate in the Daily Scrum."),
                        new Paragraph(6, "Daily Scrums improve communications, eliminate other meetings, identify impediments to development for removal, highlight and promote quick decision-making, and improve the Development Team’s level of knowledge. This is a key inspect and adapt meeting."),
                    }
                },
                new Section
                {
                    Id = 17,
                    Heading = "Sprint Review",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "A Sprint Review is held at the end of the Sprint to inspect the Increment and adapt the Product Backlog if needed. During the Sprint Review, the Scrum Team and stakeholders collaborate about what was done in the Sprint. Based on that and any changes to the Product Backlog during the Sprint, attendees collaborate on the next things that could be done to optimize value. This is an informal meeting, not a status meeting, and the presentation of the Increment is intended to elicit feedback and foster collaboration."),
                        new Paragraph(2, "This is a four-hour time-boxed meeting for one-month Sprints. For shorter Sprints, the event is usually shorter. The Scrum Master ensures that the event takes place and that attendants understand its purpose. The Scrum Master teaches all to keep it within the time-box."),
                        new Paragraph(3, "The Sprint Review includes the following elements: Attendees include the Scrum Team and key stakeholders invited by the Product Owner; The Product Owner explains what Product Backlog items have been “Done” and what has not been “Done”; The Development Team discusses what went well during the Sprint, what problems it ran into, and how those problems were solved; The Development Team demonstrates the work that it has “Done” and answers questions about the Increment; The Product Owner discusses the Product Backlog as it stands. He or she projects likely completion dates based on progress to date (if needed); The entire group collaborates on what to do next, so that the Sprint Review provides valuable input to subsequent Sprint Planning; Review of how the marketplace or potential use of the product might have changed what is the most valuable thing to do next; and, Review of the timeline, budget, potential capabilities, and marketplace for the next anticipated release of the product."),
                        new Paragraph(4, "The result of the Sprint Review is a revised Product Backlog that defines the probable Product Backlog items for the next Sprint. The Product Backlog may also be adjusted overall to meet new opportunities."),
                    }
                },
                new Section
                {
                    Id = 18,
                    Heading = "Sprint Retrospective",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Sprint Retrospective is an opportunity for the Scrum Team to inspect itself and create a plan for improvements to be enacted during the next Sprint."),
                        new Paragraph(2, "The Sprint Retrospective occurs after the Sprint Review and prior to the next Sprint Planning. This is a three-hour time-boxed meeting for one-month Sprints. For shorter Sprints, the event is usually shorter. The Scrum Master ensures that the event takes place and that attendants understand its purpose. The Scrum Master teaches all to keep it within the time-box. The Scrum Master participates as a peer team member in the meeting from the accountability over the Scrum process."),
                        new Paragraph(3, "The purpose of the Sprint Retrospective is to: Inspect how the last Sprint went with regards to people, relationships, process, and tools; Identify and order the major items that went well and potential improvements; and, Create a plan for implementing improvements to the way the Scrum Team does its work."),
                        new Paragraph(4, "The Scrum Master encourages the Scrum Team to improve, within the Scrum process framework, its development process and practices to make it more effective and enjoyable for the next Sprint. During each Sprint Retrospective, the Scrum Team plans ways to increase product quality by adapting the definition of “Done” as appropriate."),
                        new Paragraph(5, "By the end of the Sprint Retrospective, the Scrum Team should have identified improvements that it will implement in the next Sprint. Implementing these improvements in the next Sprint is the adaptation to the inspection of the Scrum Team itself. Although improvements may be implemented at any time, the Sprint Retrospective provides a formal opportunity to focus on inspection and adaptation."),
                    }
                },
                new Section
                {
                    Id = 19,
                    Heading = "Scrum Artifacts",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "Scrum’s artifacts represent work or value to provide transparency and opportunities for inspection and adaptation. Artifacts defined by Scrum are specifically designed to maximize transparency of key information so that everybody has the same understanding of the artifact."),
                    }
                },
                new Section
                {
                    Id = 20,
                    Heading = "Product Backlog",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Product Backlog is an ordered list of everything that might be needed in the product and is the single source of requirements for any changes to be made to the product. The Product Owner is responsible for the Product Backlog, including its content, availability, and ordering."),
                        new Paragraph(2, "A Product Backlog is never complete. The earliest development of it only lays out the initially known and best-understood requirements. The Product Backlog evolves as the product and the environment in which it will be used evolves. The Product Backlog is dynamic; it constantly changes to identify what the product needs to be appropriate, competitive, and useful. As long as a product exists, its Product Backlog also exists."),
                        new Paragraph(3, "The Product Backlog lists all features, functions, requirements, enhancements, and fixes that constitute the changes to be made to the product in future releases. Product Backlog items have the attributes of a description, order, estimate and value."),
                        new Paragraph(4, "As a product is used and gains value, and the marketplace provides feedback, the Product Backlog becomes a larger and more exhaustive list. Requirements never stop changing, so a Product Backlog is a living artifact. Changes in business requirements, market conditions, or technology may cause changes in the Product Backlog."),
                        new Paragraph(5, "Multiple Scrum Teams often work together on the same product. One Product Backlog is used to describe the upcoming work on the product. A Product Backlog attribute that groups items may then be employed."),
                        new Paragraph(6, "Product Backlog refinement is the act of adding detail, estimates, and order to items in the Product Backlog. This is an ongoing process in which the Product Owner and the Development Team collaborate on the details of Product Backlog items. During Product Backlog refinement, items are reviewed and revised. The Scrum Team decides how and when refinement is done. Refinement usually consumes no more than 10% of the capacity of the Development Team. However, Product Backlog items can be updated at any time by the Product Owner or at the Product Owner’s discretion."),
                        new Paragraph(7, "Higher ordered Product Backlog items are usually clearer and more detailed than lower ordered ones. More precise estimates are made based on the greater clarity and increased detail; the lower the order, the less detail. Product Backlog items that will occupy the Development Team for the upcoming Sprint are refined so that any one item can reasonably be “Done” within the Sprint time-box. Product Backlog items that can be “Done” by the Development Team within one Sprint are deemed “Ready” for selection in a Sprint Planning. Product Backlog items usually acquire this degree of transparency through the above described refining activities."),
                        new Paragraph(8, "The Development Team is responsible for all estimates. The Product Owner may influence the Development Team by helping it understand and select trade-offs, but the people who will perform the work make the final estimate."),
                    }
                },
                new Section
                {
                    Id = 21,
                    Heading = "Monitoring Progress Toward a Goal",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "At any point in time, the total work remaining to reach a goal can be summed. The Product Owner tracks this total work remaining at least every Sprint Review. The Product Owner compares this amount with work remaining at previous Sprint Reviews to assess progress toward completing projected work by the desired time for the goal. This information is made transparent to all stakeholders."),
                        new Paragraph(2, "Various projective practices upon trending have been used to forecast progress, like burn-downs, burn-ups, or cumulative flows. These have proven useful. However, these do not replace the importance of empiricism. In complex environments, what will happen is unknown. Only what has happened may be used for forward-looking decision-making."),
                    }
                },
                new Section
                {
                    Id = 22,
                    Heading = "Sprint Backlog",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Sprint Backlog is the set of Product Backlog items selected for the Sprint, plus a plan for delivering the product Increment and realizing the Sprint Goal. The Sprint Backlog is a forecast by the Development Team about what functionality will be in the next Increment and the work needed to deliver that functionality into a “Done” Increment."),
                        new Paragraph(2, "The Sprint Backlog makes visible all of the work that the Development Team identifies as necessary to meet the Sprint Goal."),
                        new Paragraph(3, "The Sprint Backlog is a plan with enough detail that changes in progress can be understood in the Daily Scrum. The Development Team modifies the Sprint Backlog throughout the Sprint, and the Sprint Backlog emerges during the Sprint. This emergence occurs as the Development Team works through the plan and learns more about the work needed to achieve the Sprint Goal."),
                        new Paragraph(4, "As new work is required, the Development Team adds it to the Sprint Backlog. As work is performed or completed, the estimated remaining work is updated. When elements of the plan are deemed unnecessary, they are removed. Only the Development Team can change its Sprint Backlog during a Sprint. The Sprint Backlog is a highly visible, real-time picture of the work that the Development Team plans to accomplish during the Sprint, and it belongs solely to the Development Team."),
                    }
                },
                new Section
                {
                    Id = 23,
                    Heading = "Monitoring Sprint Progress",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "At any point in time in a Sprint, the total work remaining in the Sprint Backlog can be summed. The Development Team tracks this total work remaining at least for every Daily Scrum to project the likelihood of achieving the Sprint Goal. By tracking the remaining work throughout the Sprint, the Development Team can manage its progress."),
                    }
                },
                new Section
                {
                    Id = 24,
                    Heading = "Increment",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "The Increment is the sum of all the Product Backlog items completed during a Sprint and the value of the increments of all previous Sprints. At the end of a Sprint, the new Increment must be “Done,” which means it must be in useable condition and meet the Scrum Team’s definition of “Done.” It must be in useable condition regardless of whether the Product Owner decides to actually release it."),
                    }
                },
                new Section
                {
                    Id = 25,
                    Heading = "Artifact Transparency",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "Scrum relies on transparency. Decisions to optimize value and control risk are made based on the perceived state of the artifacts. To the extent that transparency is complete, these decisions have a sound basis. To the extent that the artifacts are incompletely transparent, these decisions can be flawed, value may diminish and risk may increase."),
                        new Paragraph(2, "The Scrum Master must work with the Product Owner, Development Team, and other involved parties to understand if the artifacts are completely transparent. There are practices for coping with incomplete transparency; the Scrum Master must help everyone apply the most appropriate practices in the absence of complete transparency. A Scrum Master can detect incomplete transparency by inspecting the artifacts, sensing patterns, listening closely to what is being said, and detecting differences between expected and real results."),
                        new Paragraph(3, "The Scrum Master’s job is to work with the Scrum Team and the organization to increase the transparency of the artifacts. This work usually involves learning, convincing, and change. Transparency doesn’t occur overnight, but is a path."),
                    }
                },
                new Section
                {
                    Id = 26,
                    Heading = "Definition of 'Done'",
                    Paragraphs = new List<Paragraph>
                    {
                        new Paragraph(1, "When a Product Backlog item or an Increment is described as 'Done', everyone must understand what 'Done' means. Although this varies significantly per Scrum Team, members must have a shared understanding of what it means for work to be complete, to ensure transparency. This is the definition of 'Done' for the Scrum Team and is used to assess when work is complete on the product Increment."),
                        new Paragraph(2, "The same definition guides the Development Team in knowing how many Product Backlog items it can select during a Sprint Planning. The purpose of each Sprint is to deliver Increments of potentially releasable functionality that adhere to the Scrum Team’s current definition of 'Done.' Development Teams deliver an Increment of product functionality every Sprint. This Increment is useable, so a Product Owner may choose to immediately release it. If the definition of 'done' for an increment is part of the conventions, standards or guidelines of the development organization, all Scrum Teams must follow it as a minimum. If 'done' for an increment is not a convention of the development organization, the Development Team of the Scrum Team must define a definition of 'done' appropriate for the product. If there are multiple Scrum Teams working on the system or product release, the development teams on all of the Scrum Teams must mutually define the definition of 'Done.'"),
                        new Paragraph(3, "Each Increment is additive to all prior Increments and thoroughly tested, ensuring that all Increments work together."),
                        new Paragraph(4, "As Scrum Teams mature, it is expected that their definitions of 'Done' will expand to include more stringent criteria for higher quality. Any one product or system should have a definition of 'Done' that is a standard for any work done on it."),
                    }
                },
            };
        }

        private void InitializeQuestions()
        {
            Questions = new List<Question>
            {
                new Question
                {
                    Text = "Which one is true?",
                    Choices = new List<Choice>
                    {
                       new Choice(1, 1, "Scrum is a framework for developing and sustaining complex products."),
                       new Choice(0, 0, "Scrum is a set of guidelines for developing and sustaining complex products."),
                       new Choice(0, 0, "Scrum is a tool for managening, developing and sustaining complex products."),
                    }
                },
                new Question
                {
                    Text = "Which one is correct?",
                    Choices = new List<Choice>
                    {
                       new Choice(2, 2, "Scrum is: Lightweight, Simple to understand, Difficult to master."),
                       new Choice(0, 0, "Scrum is: Simple to understand, Lightweight, Difficult to master."),
                       new Choice(0, 0, "Scrum is: Simple to understand, Difficult to master, Lightweight."),
                       new Choice(0, 0, "Scrum is: Difficult to master, Simple to understand, Lightweight."),
                    }
                },
                new Question
                {
                    Text = "Which one is correct?",
                    Choices = new List<Choice>
                    {
                       new Choice(2, 2, "Scrum is: Lightweight, Simple to understand, Difficult to master."),
                       new Choice(0, 0, "Scrum is: Simple to understand, Lightweight, Difficult to master."),
                       new Choice(0, 0, "Scrum is: Simple to understand, Difficult to master, Lightweight."),
                       new Choice(0, 0, "Scrum is: Difficult to master, Simple to understand, Lightweight."),
                    }
                },
                new Question
                {
                    Text = "Scrum is founded on?",
                    Choices = new List<Choice>
                    {
                       new Choice(3, 1, "Empiricism"),
                       new Choice(0, 0, "Empiricium"),
                       new Choice(0, 0, "Empiricum"),
                       new Choice(0, 0, "Empericium"),
                       new Choice(0, 0, "Empericism"),
                       new Choice(0, 0, "Empericum"),
                    }
                },
                new Question
                {
                    Text = "How many pillars?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "One"),
                       new Choice(0, 0, "Two"),
                       new Choice(3, 2, "Three"),
                       new Choice(0, 0, "Four"),
                       new Choice(0, 0, "Five"),
                       new Choice(0, 0, "None"),
                       new Choice(0, 0, "No pillars are mentioned in The Scrum Guide"),
                    }
                },
                new Question
                {
                    Text = "What are the three pillars?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Scrum Master, the Product Owner, the Developement team"),
                       new Choice(0, 0, "The Product Owner, the Scrum Master, the Developement team"),
                       new Choice(0, 0, "The stakeholders, the Product Owner, The Scrum Master"),
                       new Choice(3, 2, "Transparency, inspection, adaptation"),
                       new Choice(0, 0, "No pillars are mentioned in The Scrum Guide"),
                       new Choice(0, 0, "There are four pillars"),
                    }
                },
                new Question
                {
                    Text = "How many Scrum events?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "One"),
                       new Choice(0, 0, "Two"),
                       new Choice(0, 0, "Three"),
                       new Choice(3, 7, "Four"),
                       new Choice(0, 0, "Five"),
                       new Choice(0, 0, "None"),
                    }
                },
                new Question
                {
                    Text = "Is Sprint Planning one of the Scrum Events?",
                    Choices = new List<Choice>
                    {
                       new Choice(3, 7, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "Is Sprint Refinement one of the Scrum Events?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Yes"),
                       new Choice(3, 7, "No"),
                    }
                },
                new Question
                {
                    Text = "Is Sprint Playing one of the Scrum Events?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Yes"),
                       new Choice(3, 7, "No"),
                    }
                },
                new Question
                {
                    Text = "Is Sprint Planning one of the Scrum Events?",
                    Choices = new List<Choice>
                    {
                       new Choice(3, 7, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "Is Sprint Review one of the Scrum Events?",
                    Choices = new List<Choice>
                    {
                       new Choice(3, 7, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "Is Sprint Retrospective one of the Scrum Events?",
                    Choices = new List<Choice>
                    {
                       new Choice(3, 7, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "The Product Owner is part of the Scrum team?",
                    Choices = new List<Choice>
                    {
                       new Choice(4, 1, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "The Scrum Master is part of the Scrum team?",
                    Choices = new List<Choice>
                    {
                       new Choice(4, 1, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "The stakeholders are part of the Scrum team?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Yes"),
                       new Choice(4, 1, "No"),
                    }
                },
                new Question
                {
                    Text = "Wich is true?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Product Owner manages the Scrum team"),
                       new Choice(0, 0, "The Product Owner manages the Developement team"),
                       new Choice(5, 1, "The Product Owner maximises the value of the product and the work of the Developement team"),
                    }
                },
                new Question
                {
                    Text = "The Product Owner manages the Developement team?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Yes"),
                       new Choice(5, 1, "No"),
                    }
                },
                new Question
                {
                    Text = "The Product Owner and the Scrum Master manages the Product Backlog?",
                    Choices = new List<Choice>
                    {
                       new Choice(5, 2, "No"),
                       new Choice(0, 0, "Yes"),
                    }
                },
                new Question
                {
                    Text = "Only the Product Owner manages the Product Backlog?",
                    Choices = new List<Choice>
                    {
                       new Choice(5, 2, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "Who manages the Product Backlog?",
                    Choices = new List<Choice>
                    {
                       new Choice(5, 2, "The Product Owner"),
                       new Choice(0, 0, "The Product Owner and the Scrum Master"),
                       new Choice(0, 0, "The Scrum Master"),
                       new Choice(0, 0, "The Scrum Master and the Developement Team"),
                       new Choice(0, 0, "The Developement Team"),
                    }
                },
                new Question
                {
                    Text = "Who manages the Sprint Backlog during the sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Product Owner"),
                       new Choice(0, 0, "The Product Owner and the Scrum Master"),
                       new Choice(0, 0, "The Scrum Master"),
                       new Choice(0, 0, "The Scrum Master and the Developement Team"),
                       new Choice(14, 8, "The Developement Team"),
                    }
                },
                new Question
                {
                    Text = "The Product Owner can be a committee?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "True"),
                       new Choice(5, 4, "False"),
                    }
                },
                new Question
                {
                    Text = "The Product Owner is a committee?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "True"),
                       new Choice(5, 4, "False"),
                    }
                },
                new Question
                {
                    Text = "The Product Owner is not a committee?",
                    Choices = new List<Choice>
                    {
                       new Choice(5, 4, "True"),
                       new Choice(0, 0, "False"),
                    }
                },
                new Question
                {
                    Text = "The Increment is created by who?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "The Product owner"),
                        new Choice(0, 0, "The Scrum Master"),
                        new Choice(6, 1, "The Developement team"),
                        new Choice(0, 0, "The Developement team and the Scrum master"),
                        new Choice(0, 0, "The Developement team and the Product owner"),
                        new Choice(0, 0, "The Scrum team"),                    }
                },
                new Question
                {
                    Text = "What is the optimal number of different titles on the Developement team?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "3"),
                        new Choice(0, 0, "5"),
                        new Choice(0, 0, "8"),
                        new Choice(0, 0, "9"),
                        new Choice(0, 0, "All the kinds af titles that needed to reach the Sprint Goal"),
                        new Choice(6, 3, "No titles are recognized"),
                    }
                },
                new Question
                {
                    Text = "What is the optimal number of members of the Developement team?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "3"),
                        new Choice(0, 0, "5"),
                        new Choice(0, 0, "8"),
                        new Choice(0, 0, "9"),
                        new Choice(6, 4, "3 to 9"),
                        new Choice(0, 0, "As many members needed to reach the sprint Goal"),
                    }
                },
                new Question
                {
                    Text = "In an organization, should the Scrum Master work with other Scrum Masters?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "No"),
                        new Choice(10, 1, "Yes"),
                    }
                },
                new Question
                {
                    Text = "Who should plan the implementation of Scrum in the organization?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "The Product Owner"),
                        new Choice(0, 0, "Management"),
                        new Choice(10, 1, "The Scrum Master"),
                        new Choice(0, 0, "The Scrum team"),
                        new Choice(0, 0, "The Developement team"),
                    }
                },
                new Question
                {
                    Text = "Wich of the Scrum events are time-boxed?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "Only the Daily scrum"),
                        new Choice(0, 0, "Scrum Planning and Daily scrum"),
                        new Choice(0, 0, "Scrum Planning, Daily scrum and Sprint Retrospective"),
                        new Choice(0, 0, "The Scrum Master decides wich events are time-boxed"),
                        new Choice(0, 0, "The Developement team decides wich events are time-boxed"),
                        new Choice(11, 1, "All events are time-boxed"),
                    }
                },
                new Question
                {
                    Text = "How long is the Sprint time-box?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "15 minutes"),
                        new Choice(0, 0, "4 hours"),
                        new Choice(0, 0, "8 hours"),
                        new Choice(0, 0, "One month"),
                        new Choice(12, 1, "One month or less"),
                        new Choice(0, 0, "The sprint is not time-boxed"),
                    }
                },
                new Question
                {
                    Text = "The Sprint time-box can be shorter than a month?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "False"),
                       new Choice(12, 1, "True"),
                    }
                },
                new Question
                {
                    Text = "The Sprint time-box can be longer than a month?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "True"),
                       new Choice(12, 1, "False"),
                    }
                },
                new Question
                {
                    Text = "Is the developement work considered a scrum event?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "False"),
                       new Choice(12, 2, "True"),
                    }
                },
                new Question
                {
                    Text = "What is the Sprint time-box?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "15 days"),
                       new Choice(0, 0, "15 minutes"),
                       new Choice(0, 0, "3 to 9 weeks"),
                       new Choice(0, 0, "3 to 9 months"),
                       new Choice(12, 5, "1 months"),
                       new Choice(0, 0, "7 plus or minus 2 weeks"),
                    }
                },
                new Question
                {
                    Text = "If a Sprint is longer than a month, then complexity may rise, and risk may increase?",
                    Choices = new List<Choice>
                    {
                       new Choice(12, 5, "True"),
                       new Choice(0, 0, "False"),
                    }
                },
                new Question
                {
                    Text = "Can the Developement team cancel a Sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(13, 1, "False"),
                       new Choice(0, 0, "True"),
                    }
                },
                new Question
                {
                    Text = "Can the Product owner cancel a Sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "False"),
                       new Choice(13, 1, "True"),
                    }
                },
                new Question
                {
                    Text = "Can the the Scrum Master advise the Product owner to cancel a Sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "False"),
                       new Choice(13, 1, "True"),
                    }
                },
                new Question
                {
                    Text = "Who can cancel a Sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Developement team"),
                       new Choice(0, 0, "The Developement team and the Scrum master"),
                       new Choice(0, 0, "The Developement team and the Product owner"),
                       new Choice(0, 0, "The Scrum Master"),
                       new Choice(13, 1, "The Product owner"),
                       new Choice(0, 0, "The whole Scrum team should agree to cancel the Sprint"),
                    }
                },
                new Question
                {
                    Text = "Can the Sprint Goal become obsolete?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "False"),
                       new Choice(13, 2, "True"),
                    }
                },
                new Question
                {
                    Text = "At what event is it desided what work should be done during the sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Sprint Review"),
                       new Choice(14, 1, "Sprint Planning"),
                       new Choice(0, 0, "Daily Scrum"),
                       new Choice(0, 0, "The Product owner always desides"),
                    }
                },
                new Question
                {
                    Text = "How long is the Sprint Planning time-box?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "15 minutes"),
                       new Choice(0, 0, "4 hours"),
                       new Choice(14, 1, "8 hours"),
                       new Choice(0, 0, "One month"),
                       new Choice(0, 0, "One month or less"),
                       new Choice(0, 0, "The Sprint Planning is not time-boxed"),
                    }
                },            
                new Question
                {
                    Text = "The Sprint Planning time-box can be shorter than 4 hours?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Yes"),
                       new Choice(14, 2, "No"),
                    }
                },            
                new Question
                {
                    Text = "The Sprint Planning time-box can be longer than 4 hours?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "False"),
                       new Choice(14, 2, "True"),
                    }
                },
                new Question
                {
                    Text = "The Sprint Planning time-box can be shorter than 8 hours?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "False"),
                       new Choice(14, 2, "True"),
                    }
                },            
                new Question
                {
                    Text = "The Sprint Planning time-box can be longer than 8 hours?",
                    Choices = new List<Choice>
                    {
                       new Choice(14, 2, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "Who ensure that the Sprint Planning takes place?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Product owner"),
                       new Choice(14, 2, "The Scrum Master"),
                       new Choice(0, 0, "The Developement team"),
                       new Choice(0, 0, "The stakeholders"),
                       new Choice(0, 0, "The Scrum team"),
                    }
                },            
                new Question
                {
                    Text = "Who decides what the Sprint Goal should be?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Product owner"),
                       new Choice(0, 0, "The Scrum Master"),
                       new Choice(14, 6, "The Developement team"),
                       new Choice(0, 0, "The Developement team and the Scrum master"),
                       new Choice(0, 0, "The Developement team and the Product owner"),
                       new Choice(0, 0, "The Scrum team"),
                    }
                },            
                new Question
                {
                    Text = "How many items from the Product Backlog should be picked during Sprint Planning?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Always 15 items"),
                       new Choice(0, 0, "The Scrum Master decides"),
                       new Choice(14, 5, "The Developement team decides"),
                       new Choice(0, 0, "The Product owner decides"),
                       new Choice(0, 0, "The whole Scrum team decides together"),
                       new Choice(0, 0, "3 to 9 items"),
                    }
                },            
                new Question
                {
                    Text = "If all work is done before the end of the Sprint, who decides what backlog items to start work on?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Product owner"),
                       new Choice(0, 0, "The Scrum Master"),
                       new Choice(0, 0, "The Developement team"),
                       new Choice(0, 0, "The Developement team and the Scrum master"),
                       new Choice(14, 8, "The Developement team and the Product owner"),
                       new Choice(0, 0, "The Scrum team"),
                    }
                },            
                new Question
                {
                    Text = "Wich is true?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Scrum Master can help to clarify the selected Product Backlog items and make trade-offs. "),
                       new Choice(14, 9, "The Product Owner can help to clarify the selected Product Backlog items and make trade-offs. "),
                    }
                },
                new Question
                {
                    Text = "Wich is true?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Scrum Master can help to clarify the selected Product Backlog items and make trade-offs. "),
                       new Choice(14, 9, "The Product Owner can help to clarify the selected Product Backlog items and make trade-offs. "),
                    }
                },
                new Question
                {
                    Text = "What is the Daily Scrum time-box?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Scrum Master decides"),
                       new Choice(0, 0, "The Developement team decides"),
                       new Choice(0, 0, "The Product owner decides"),
                       new Choice(16, 1, "15 minutes"),
                       new Choice(0, 0, "4 hours"),
                       new Choice(0, 0, "8 hours"),
                    }
                },            
                new Question
                {
                    Text = "The Scrum Master is not:",
                    Choices = new List<Choice>
                    {
                       new Choice(16, 4, "conducting the Daily Scrum"),
                       new Choice(0, 0, "present at the Daily Scrum"),
                    }
                },            
                new Question
                {
                    Text = "The Daily scrum is the key to:",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Keeping up the team spirit"),
                       new Choice(0, 0, "Socializing with your colleagues"),
                       new Choice(16, 6, "Inspecting and adapting"),
                       new Choice(0, 0, "Plan the work for the day"),
                    }
                },   
                new Question
                {
                    Text = "When is the Sprint Review held?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "At Daily Scrum"),
                       new Choice(0, 0, "After Sprint Planning"),
                       new Choice(17, 1, "At the end of the Sprint"),
                       new Choice(0, 0, "The Developement team and Product owner decides"),
                       new Choice(0, 0, "The Scrum Master and Product owner decides"),
                       new Choice(0, 0, "The Developement team decides when"),
                    }
                },   
                new Question
                {
                    Text = "Is the Sprint Review a formal or an informal meeting?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "Formal"),
                        new Choice(17, 1, "Informal"),
                    }
                },   
                new Question
                {
                    Text = "How long is the time-box for the Sprint Review?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "2 hours"),
                        new Choice(17, 2, "4 hours"),
                        new Choice(0, 0, "8 hours"),
                        new Choice(0, 0, "One month"),
                        new Choice(0, 0, "One month or less"),
                        new Choice(0, 0, "The Sprint Review is not time-boxed"),
                    }
                },   
                new Question
                {
                    Text = "Is it the Product Owner that ensures the Sprint Review takes place?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "Yes"),
                        new Choice(17, 2, "No"),
                    }
                },   
                new Question
                {
                    Text = "The Scrum Master ensures the Sprint Review takes place?",
                    Choices = new List<Choice>
                    {
                        new Choice(17, 2, "Yes"),
                        new Choice(0, 0, "No"),
                    }
                }, 
                new Question
                {
                    Text = "What is the result of the Sprint Review?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "The Sprint Backlog for the next Sprint"),
                        new Choice(17, 4, "A revised Product Backlog"),
                        new Choice(0, 0, "A revised Sprint Backlog for the current Sprint"),
                        new Choice(0, 0, "A status report for the Product Owner"),
                    }
                }, 
                new Question
                {
                    Text = "Can the Sprint Backlog be adjusted in the Sprint Review?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "Yes"),
                        new Choice(0, 0, "No"),
                        new Choice(17, 4, "None of the above"),
                    }
                }, 
                new Question
                {
                    Text = "Can the Product Backlog be adjusted in the Sprint Review?",
                    Choices = new List<Choice>
                    {
                        new Choice(17, 4, "Yes"),
                        new Choice(0, 0, "No"),
                        new Choice(0, 0, "None of the above"),
                    }
                }, 
                new Question
                {
                    Text = "The Sprint Retrospective is a demo of what has been done during the Sprint?",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "Yes"),
                        new Choice(18, 1, "No"),
                        new Choice(0, 0, "None of the above"),
                    }
                }, 
                new Question
                {
                    Text = "The Sprint Retrospective is not",
                    Choices = new List<Choice>
                    {
                        new Choice(0, 0, "time-boxed"),
                        new Choice(0, 0, "a meeting"),
                        new Choice(0, 0, "after the Sprint Review"),
                        new Choice(18, 2, "held after Daily Scrum"),
                        new Choice(0, 0, "a Scrum Event"),
                    }
                }, 
                new Question
                {
                    Text = "When does the Scrum team inspect how the last Sprint went?",
                    Choices = new List<Choice>
                    {
                        new Choice(18, 3, "At Sprint Retrospective"),
                        new Choice(0, 0, "During developement"),
                        new Choice(0, 0, "At Daily Scrum"),
                        new Choice(0, 0, "At the Sprint Review"),
                        new Choice(0, 0, "At Sprint Planning"),
                    }
                }, 
                new Question
                {
                    Text = "Who is responsible for the Product Backlog?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The stakeholders"),
                       new Choice(20, 1, "The Product Owner"),
                       new Choice(0, 0, "The Product Owner and the Scrum Master"),
                       new Choice(0, 0, "The Scrum Master"),
                       new Choice(0, 0, "The Scrum Master and the Developement Team"),
                       new Choice(0, 0, "The Developement Team"),
                    }
                },
                new Question
                {
                    Text = "The items in the Product Backlog are all equally important?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Yes"),
                       new Choice(20, 1, "No, the items are ordered"),
                       new Choice(0, 0, "Only the Product Owner should know the order of the items"),
                    }
                },
                new Question
                {
                    Text = "The Product Backlog should be as complete as possible when the project starts?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Yes"),
                       new Choice(20, 2, "No, the Backlog is never complete"),
                       new Choice(0, 0, "It depends"),
                    }
                },
                new Question
                {
                    Text = "Wich is wrong?",
                    Choices = new List<Choice>
                    {
                       new Choice(20, 2, "The Product Backlog is static"),
                       new Choice(0, 0, "The Product Backlog is constantly changes"),
                    }
                },
                new Question
                {
                    Text = "Only the most important features should be on the Product Backlog?",
                    Choices = new List<Choice>
                    {
                       new Choice(20, 3, "No, all features should be on the Product Backlog"),
                       new Choice(0, 0, "Yes, only the most important should be on the Product."),
                       new Choice(0, 0, "None of the above"),
                    }
                },
                new Question
                {
                    Text = "Only the most important features should be on the Product Backlog?",
                    Choices = new List<Choice>
                    {
                       new Choice(20, 3, "No, all features should be on the Product Backlog"),
                       new Choice(0, 0, "Yes, only the most important should be on the Product."),
                       new Choice(0, 0, "None of the above"),
                    }
                },
                new Question
                {
                    Text = "Only the most important features should be on the Product Backlog?",
                    Choices = new List<Choice>
                    {
                       new Choice(20, 2, "No, all features should be on the Product Backlog"),
                       new Choice(0, 0, "Yes"),
                       new Choice(0, 0, "None of the above"),
                    }
                },
                new Question
                {
                    Text = "In an organisation where multiple teams work on the same product, how many Product Backlogs should each team have?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "One Product Backlog for each team"),
                       new Choice(0, 0, "One Product Backlog for each feature of the product"),
                       new Choice(20, 5, "One Product Backlog used for all teams"),
                    }
                },
                new Question
                {
                    Text = "Backlog Refinement usually consumes no more than",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "15 minutes"),
                       new Choice(0, 0, "3 to 9 percent of the Developement teams capacity"),
                       new Choice(0, 0, "1 month for large projects but often less for smaller projects"),
                       new Choice(20, 6, "10 percent"),
                       new Choice(0, 0, "15 percent"),
                    }
                },
                new Question
                {
                    Text = "Who estimates the Product Backlog items?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Product Owner"),
                       new Choice(0, 0, "The stakeholders"),
                       new Choice(0, 0, "The Product Owner and the Scrum Master"),
                       new Choice(0, 0, "The Scrum Master"),
                       new Choice(0, 0, "The Scrum Master and the Developement Team"),
                       new Choice(20, 8, "The Developement Team"),
                    }
                },
                new Question
                {
                    Text = "The Sprint Backlog is a set of Product Backlog items?",
                    Choices = new List<Choice>
                    {
                       new Choice(22, 1, "True"),
                       new Choice(0, 0, "False"),
                    }
                },
                new Question
                {
                    Text = "Can the Sprint Backlog be changed during the sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "No"),
                       new Choice(22, 3, "Yes"),
                    }
                },
                new Question
                {
                    Text = "The Sprint Backlog has to be complete before the sprint can start?",
                    Choices = new List<Choice>
                    {
                       new Choice(22, 3, "False"),
                       new Choice(0, 0, "True"),
                    }
                },
                new Question
                {
                    Text = "If new work is identified that is needed to reach the Sprint Goal,",
                    Choices = new List<Choice>
                    {
                       new Choice(22, 4, "the work items should be added to the Sprint Backlog"),
                       new Choice(0, 0, "the work items should be added to the Product Backlog"),
                    }
                },
                new Question
                {
                    Text = "Can work items be removed from the Sprint Backlog?",
                    Choices = new List<Choice>
                    {
                       new Choice(22, 4, "Yes"),
                       new Choice(0, 0, "No"),
                    }
                },
                new Question
                {
                    Text = "Who can make changes to the Sprint Backlog during the sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "The Product Owner"),
                       new Choice(0, 0, "The stakeholders"),
                       new Choice(0, 0, "The Product Owner and the Scrum Master"),
                       new Choice(0, 0, "The Scrum Master"),
                       new Choice(0, 0, "The Scrum Master and the Developement Team"),
                       new Choice(22, 4, "The Developement Team"),
                    }
                },
                new Question
                {
                    Text = "When is the total remaining work summed?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Before Sprint planning"),
                       new Choice(23, 1, "At Daily Scrum"),
                       new Choice(0, 0, "At the Sprint Review"),
                       new Choice(0, 0, "At the Sprint Retrospective"),
                    }
                },
                new Question
                {
                    Text = "Should the Developement team track how much work has been completed during the sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "No"),
                       new Choice(23, 1, "Yes"),
                    }
                },
                new Question
                {
                    Text = "What is the Increment?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "One completed work item."),
                       new Choice(24, 1, "The sum of all completed work items during the Sprint."),
                    }
                },
                new Question
                {
                    Text = "What is the Increment?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "One completed work item."),
                       new Choice(24, 1, "The sum of all completed work items during the Sprint."),
                    }
                },
                new Question
                {
                    Text = "The Increment should be done at the end of the sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(24, 1, "Yes."),
                       new Choice(0, 0, "No."),
                       new Choice(0, 0, "The Product owner decides"),
                       new Choice(0, 0, "The Developement team and Product owner decides"),
                       new Choice(0, 0, "The Scrum Master and Product owner decides"),
                       new Choice(0, 0, "The Developement team decides"),
                    }
                },
                new Question
                {
                    Text = "The Increment should be useable at the end of the sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(24, 1, "Yes."),
                       new Choice(0, 0, "No."),
                       new Choice(0, 0, "The Product owner decides"),
                       new Choice(0, 0, "The Developement team and Product owner decides"),
                       new Choice(0, 0, "The Scrum Master and Product owner decides"),
                       new Choice(0, 0, "The Developement team decides"),
                    }
                },
                new Question
                {
                    Text = "The Increment should be released at the end of the sprint?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "No."),
                       new Choice(0, 0, "Yes."),
                       new Choice(24, 1, "The Product owner decides"),
                       new Choice(0, 0, "The Developement team and Product owner decides"),
                       new Choice(0, 0, "The Scrum Master and Product owner decides"),
                       new Choice(0, 0, "The Developement team decides"),
                    }
                },
                new Question
                {
                    Text = "Why transparency?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "To help the management monitor progress"),
                       new Choice(25, 1, "To ensure that decisions have a sound basis"),
                       new Choice(0, 0, "To help the Product owners decide Product backlog work item priorities."),
                       new Choice(0, 0, "To avoid unnessary socialising."),
                    }
                },
                new Question
                {
                    Text = "The Scrum Master’s job is to work with the Scrum Team and the organization to increase the transparency of the artifacts.",
                    Choices = new List<Choice>
                    {
                       new Choice(25, 3, "True"),
                       new Choice(0, 0, "False"),
                    }
                },
                new Question
                {
                    Text = "The Scrum Master’s job is to work with the Scrum Team and the organization to increase the transparency of the artifacts.",
                    Choices = new List<Choice>
                    {
                       new Choice(25, 3, "True"),
                       new Choice(0, 0, "False"),
                    }
                },
                new Question
                {
                    Text = "The Scrum Master is the only one to work on increasing the transparency of the artifacts.",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "True"),
                       new Choice(25, 3, "False"),
                    }
                },
                new Question
                {
                    Text = "If the increment is done the Product Owner should release it",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "Yes"),
                       new Choice(26, 2, "No"),
                    }
                },
                new Question
                {
                    Text = "When many Developement teams are working together on a single product, how many Definition of done should they have?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "None"),
                       new Choice(0, 0, "Each Developement Teams decides what their Definition of Done should be"),
                       new Choice(26, 2, "One Definition of Done for all teams"),
                       new Choice(0, 0, "The Product Owner decides the Definition of Done"),
                    }
                },
                new Question
                {
                    Text = "When many Developement teams are working together on a single product, how many Definition of done should they have?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "None"),
                       new Choice(0, 0, "Each Developement Teams decides what their Definition of Done should be"),
                       new Choice(26, 2, "One Definition of Done for all teams"),
                       new Choice(0, 0, "The Product Owner decides the Definition of Done"),
                    }
                },
                new Question
                {
                    Text = "The Definition of done is changed when?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "It should not be changed"),
                       new Choice(0, 0, "When the Product Owner and the stakeholders decides it time"),
                       new Choice(26, 4, "It should evolve as the Scrum Team matures"),
                    }
                },
                new Question
                {
                    Text = "The Definition of done should be the same for the whole organisation?",
                    Choices = new List<Choice>
                    {
                       new Choice(0, 0, "A committee in the organisation should decide"),
                       new Choice(0, 0, "The Product Owner should decide"),
                       new Choice(0, 0, "Each Developement Team in the organisation should have its own"),
                       new Choice(26, 4, "Each product in the organisation should have its own"),
                    }
                },
            };
        }
    }
}

