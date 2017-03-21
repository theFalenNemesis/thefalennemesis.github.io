var bio = {
    "name" : "Brandon Onken",
    "role" : "Web Developer",
    "contacts" : {
        "mobile" : "309-219-2035",
        "email" : "bonken1992@gmail.com",
        "github" : "theFalenNemesis",
        "location" : "Peoria, IL"
    },
    "welcomeMessage" : "I am technologically inclined, a fast learner, and motivated. I am currently enrolled at ICC for Computer Programming and Database Development while also taking various online courses.",
    "skills" : ["HTML", "CSS", "JavaScript", "jQuery", "PHP", "Java", "Android Development", "Visual Basic", "Visual C#", "Python", "mySQL"],
    "biopic" : "images/me.jpg",
    "display" : function () {
        var formattedName = HTMLheaderName.replace("%data%", bio.name);
        var formattedRole = HTMLheaderRole.replace("%data%", bio.role);
        $("#header").prepend(formattedName, formattedRole);
        //$("#header").prepend(formattedName);

        var formattedMobile = HTMLmobile.replace("%data%", bio.contacts.mobile);
        $("#topContacts, #footerContacts").append(formattedMobile);
        //$("#footerContacts").append(formattedMobile);
        
        var formattedEmail = HTMLemail.replace("%data%", bio.contacts.email);
        $("#topContacts, #footerContacts").append(formattedEmail);
        //$("#footerContacts").append(formattedMobile);
        
        var formattedGithub = HTMLgithub.replace("%data%", bio.contacts.github);
        $("#topContacts, #footerContacts").append(formattedGithub);
        //$("#footerContacts").append(formattedGithub);
        
        var formattedLocation = HTMLlocation.replace("%data%", bio.contacts.location);
        $("#topContacts, #footerContacts").append(formattedLocation);
        //$("#footerContacts").append(formattedLocation);

        var formattedBioPic = HTMLbioPic.replace("%data%", bio.biopic);
        $("#header").append(formattedBioPic);
        
        var formattedWelcomeMsg = HTMLwelcomeMsg.replace("%data%", bio.welcomeMessage);
        $("#header").append(formattedWelcomeMsg);

        if (bio.skills.length > 0) {
            $("#header").append(HTMLskillsStart);

            var formattedSkill;

            for (var count = 0; count < bio.skills.length; count++) {
                formattedSkill = HTMLskills.replace("%data%", bio.skills[count]);
                $("#skills").append(formattedSkill);
            }
        }
    }
};

var work = {
    "jobs" : [
        {
            "title" : "Counter Attendant / Lane Mechanic",
            "employer" : "The Christian Center",
            "dates" : "August 2009 - Present",
            "description" : "Manage Bowling Counter and handle machine breakdowns.",
            "location" : "Peoria, IL"
        },
        {
            "title" : "Target Mobile Rep",
            "employer" : "Marketsource",
            "dates" : "October 2015 - March 2016",
            "description" : "Selling and activating phones and accesories.",
            "location" : "East Peoria, IL"
        },
        {
            "title" : "Recieving",
            "employer" : "Wal-Mart",
            "dates" : "March 2011 - June 2011",
            "description" : "Unload trucks and pull product to the floor.",
            "location" : "Peoria, IL"
        },
        {
            "title" : "Landscaper",
            "employer" : "Commercial Grounds Maintenance",
            "dates" : "May 2010 - August 2010",
            "description" : "Mowing, tree/bush trimming, shoveling and cementing.",
            "location" : "Peoria, IL"
        },
        {
            "title" : "Grill Cook",
            "employer" : "McDonald's",
            "dates" : "May 2008 - July 2008",
            "description" : "Food preperation.",
            "location" : "Bartonville, IL"
        }
    ],
    "display" : function() {
        for (var count = 0; count < work.jobs.length; count++) {
            $("#workExperience").append(HTMLworkStart);

            var formattedEmployer = HTMLworkEmployer.replace("%data%", work.jobs[count].employer);
            var formattedTitle = HTMLworkTitle.replace("%data%", work.jobs[count].title);
            var formattedEmployerTitle = formattedEmployer + formattedTitle;

            $(".work-entry:last").append(formattedEmployerTitle);

            var formattedDates = HTMLworkDates.replace("%data%", work.jobs[count].dates);
            $(".work-entry:last").append(formattedDates);

            var formattedDescription = HTMLworkDescription.replace("%data%", work.jobs[count].description);
            $(".work-entry:last").append(formattedDescription);
        }
    }
};

var education = {
    "schools" : [
        {
            "name" : "Illinois Central College",
            "location" : "East Peoria, IL",
            "degree" : "Certificate",
            "major" : ["CS"],
            "dates" : "Ongoing",
            "url" : "https://icc.edu/"
        }
    ],
    "onlineCourses" : [
        {
            "title" : "Front-End Web Developer",
            "school" : "Udacity",
            "dates" : "2017",
            "url" : "http://www.udacity.com"
        },
        {
            "title" : "Complete Web Developer Course",
            "school" : "Udemy",
            "dates" : "2017",
            "url" : "http://www.udemy.com"
        }
    ],
    "display" : function() {
        for (var count = 0; count < education.schools.length; count++) {
            $("#education").append(HTMLschoolStart);

            var formattedSchoolName = HTMLschoolName.replace("%data%", education.schools[count].name);
            //$(".education-entry:last").append(formattedSchoolName);

            var formattedSchoolDegree = HTMLschoolDegree.replace("%data%", education.schools[count].degree);
            var formattedSchoolNameDegree = formattedSchoolName + formattedSchoolDegree;
            $(".education-entry:last").append(formattedSchoolNameDegree);

            var formattedSchoolDates = HTMLschoolDates.replace("%data%", education.schools[count].dates);
            $(".education-entry:last").append(formattedSchoolDates);

            var formattedSchoolLocation = HTMLschoolLocation.replace("%data%", education.schools[count].location);
            $(".education-entry:last").append(formattedSchoolLocation);

            var formattedSchoolMajor = HTMLschoolMajor.replace("%data%", education.schools[count].major);
            $(".education-entry:last").append(formattedSchoolMajor);
            
            var formattedSchoolUrl = HTMLschoolURL.replace("%data%", education.schools[count].url);
            var formattedSchoolUrl = formattedSchoolUrl.replace("#", education.schools[count].url);
            $(".education-entry:last").append(formattedSchoolUrl);
        }

        $(".education-entry:last").append(HTMLonlineClasses);

        for (var index = 0; index < education.onlineCourses.length; index++) {
            var formattedOnlineTitle = HTMLonlineTitle.replace("%data%", education.onlineCourses[index].title);

            var formattedOnlineSchool = HTMLonlineSchool.replace("%data%", education.onlineCourses[index].school);
            var formattedOnlineTitleSchool = formattedOnlineTitle + formattedOnlineSchool;
            $(".education-entry:last").append(formattedOnlineTitleSchool);

            var formattedOnlineDates = HTMLonlineDates.replace("%data%", education.onlineCourses[index].dates);
            $(".education-entry:last").append(formattedOnlineDates);

            var formattedOnlineURL = HTMLonlineURL.replace("%data%", education.onlineCourses[index].url);
            var formattedOnlineURL = formattedOnlineURL.replace("#", education.onlineCourses[index].url);
            $(".education-entry:last").append(formattedOnlineURL);
        }
    }
};

var projects = {
    "projects" : [
        {
            "title" : "Code Player",
            "dates" : "2017",
            "description" : "A simple website that allows the user to see immediate results of HTML, CSS, and JavaScript",
            "images" : ["images/code-player-img.png"]
        },
        {
            "title" : "Reaction Tester",
            "dates" : "2017",
            "description" : "A fun JavaScript game with shapes for the user to test their reaction time.",
            "images" : ["images/reaction-img.png"]
        }
    ],
    
    "display" : function() {
//        for (var count = 0; count < projects.projects.length; count++) {
//            $("#projects").append(HTMLprojectStart);
//
//            var formattedProjectTitle = HTMLprojectTitle.replace("%data%", projects.projects[count].title);
//            $(".project-entry:last").append(formattedProjectTitle);
//
//            var formattedProjectDates = HTMLprojectDates.replace("%data%", projects.projects[count].dates);
//            $(".project-entry:last").append(formattedProjectDates);
//
//            var formattedProjectDescription = HTMLprojectDescription.replace("%data%", projects.projects[count].description);
//            $(".project-entry:last").append(formattedProjectDescription);
//            
//            var formattedProjectImage = HTMLprojectImage.replace("%data%", projects.projects[count].images);
//            $(".project-entry:last").append(formattedProjectImage);
//        }
        $("#projects").append(HTMLprojectStart);
        
        var formattedProjectTitle = HTMLprojectTitle.replace("%data%", "Check out my GitHub");
        var formattedProjectTitle = formattedProjectTitle.replace("#", "https://github.com/thefalennemesis");
        $(".project-entry:last").append(formattedProjectTitle);
        var formattedProjectTitle = HTMLprojectTitle.replace("%data%", "Check out my Portfolio");
        var formattedProjectTitle = formattedProjectTitle.replace("#", "https://thefalennemesis.github.io/");
        $(".project-entry:last").append(formattedProjectTitle);
    }
};

bio.display();
work.display();
education.display();
projects.display();

$("#main").append(internationalizeButton);

function inName(name) {
    name = name.trim().split(" ");
    console.log(name);
    name[1] = name[1].toUpperCase();
    name[0] = name[0].slice(0,1).toUpperCase() + name[0].slice(1).toLowerCase();
    
    return name[0] + " " + name[1];
}

$("#mapDiv").append(googleMap);