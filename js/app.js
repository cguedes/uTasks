
App = Ember.Application.create({
  LOG_TRANSITIONS: true
});

App.Router.reopen({
  //location: 'history'
});

function Contact(contactType, contactIcon, contactLink) {
  this.contactType = contactType;
  this.contactIcon = contactIcon;
  this.contactLink = contactLink;
}

App.Contacts = { 
  contacts: [
    new Contact("Linked in", "icon-linkedin-sign", "http://pt.linkedin.com/in/cguedes/"),
    new Contact("Github",   "icon-github", "http://cguedes.github.com"),
    new Contact("Twitter", "icon-twitter-sign", "https://twitter.com/cguedes"),
    new Contact("Email", "icon-envelope", "cguedes_AT_gmail"),
  ]
};

App.ContactsRoute = Ember.Route.extend({
  model: function() { return App.Contacts; }
});

App.Router.map(function() {
  this.resource("about");
  this.resource("contacts");
  this.resource("projects");
  this.resource("talks");
  this.resource("blog");
});


Ember.Handlebars.registerBoundHelper('date', function(date) {
  return moment(date).fromNow();
});

var converter = new Showdown.converter();
Ember.Handlebars.registerBoundHelper('markdown', function(text) {
  var html = converter.makeHtml(text);
  return new Handlebars.SafeString(html);
});

