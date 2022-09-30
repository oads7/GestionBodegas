import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Warehouse } from 'src/app/models/warehouse.model';
import { WarehouseService } from 'src/app/services/warehouse.service';


@Component
({
    selector: 'app-sidebar',
    templateUrl: './sidebar.component.html',
    styleUrls: [ './sidebar.component.css' ]
})
export class SidebarComponent implements OnInit
{
    warehousesList : Warehouse[] = [];

    constructor(private router : Router,
                private warehouseService : WarehouseService)
    { }

    ngOnInit() : void
    {
        this.warehouseService.getAllWarehouses().subscribe(response =>
        {
            this.warehousesList = response.data;
        });
    }

    changeWarehouse(event : any) : void
    {
        localStorage.setItem("SelectedWarehouse", event.target.selectedIndex);
        this.reloadCurrentRoute();
    }

    reloadCurrentRoute()
    {
        let currentUrl: string = this.router.url;

        this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
            this.router.navigate([currentUrl.toString()])
        });
    }

    redirectToListProduct()
    {
        this.router.navigate(['/products-list']);
    }
    
    redirectToCreateProduct()
    {
        this.router.navigate(['/create-product']);
    }
    
    redirectToListWarehouses()
    {
        this.router.navigate(['/warehouses-list']);
    }
    
}
