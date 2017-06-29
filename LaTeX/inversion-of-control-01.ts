<p id="foo">Foo</p>

var foo = 
 document.getElementById('foo');

foo.addEventListener(
  'click', 
  () => alert('They called us.'));

foo.addEventListener(
  'click', 
  () => alert('They called us too.'));

