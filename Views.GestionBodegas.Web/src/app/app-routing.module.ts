import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SidebarComponent } from './layout/sidebar/sidebar.component';

const routes: Routes = 
[
    {
        path: '', component: SidebarComponent,
        data: { title: 'Inicio' },
        children:
        [
            {
                path: 'create-product',
                loadChildren: () => import('./views/create-product/create-product.module').then(m => m.CreateProductModule)
            },
            {
                path: 'products-list',
                loadChildren: () => import('./views/products-list/products-list.module').then(m => m.ProductsListModule)
            },
            {
                path: 'warehouses-list',
                loadChildren: () => import('./views/warehouses-list/warehouses-list.module').then(m => m.WarehousesListModule)
            },
        ]
    }
];

@NgModule
({
    imports: [ RouterModule.forRoot(routes) ],
    exports: [ RouterModule ]
})
export class AppRoutingModule { }
