import { OnInit, Component } from '@angular/core';
import { faStar, faTags } from '@fortawesome/free-solid-svg-icons';

@Component({
    selector: 'app-sidebar',
    templateUrl: './sidebar.component.html',
    styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {
    faStar = faStar;
    faTags = faTags;

    constructor() { }

    ngOnInit() { }
}