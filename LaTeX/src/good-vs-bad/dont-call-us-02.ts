// OnInit is an Angular lifecycle hook interface 
export class PeekABoo implements OnInit {
  ngOnInit() {
    alert('They called us.");

    // we could now call a library
    d3.select("body")
      .style("color", "black")
      .style("background-color", "white");
  }
}

