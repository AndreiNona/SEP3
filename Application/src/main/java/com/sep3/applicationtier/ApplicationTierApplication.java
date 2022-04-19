package com.sep3.applicationtier;

import RESTClientConnection.OrderController;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;

@SpringBootApplication
@ComponentScan(basePackageClasses = OrderController.class)
public class ApplicationTierApplication {

    public static void main(String[] args) {
        SpringApplication.run(ApplicationTierApplication.class, args);
    }

}
